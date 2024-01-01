using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;



public class Re_CharacterManager : MonoBehaviour
{

    [SerializeField]
    Transform[] playerPos = new Transform[3];

    [SerializeField]
    Transform[] monsterpos = new Transform[3];

    int maxPlayerCapa = 3;
    int maxMosterCapa = 3;

    public List<GameObject> playerArray = new List<GameObject>();
    public List<GameObject> enemyArray = new List<GameObject>();

    Dictionary<int, List<GameObject> > enemyDict = new Dictionary<int, List<GameObject>>();
    EnemyEnum[] enemyEnums = (EnemyEnum[])Enum.GetValues(typeof(EnemyEnum));
    int currentEnemyParty;


    public BattleManager battleManager;
    bool isAlreday = false;


    public GameObject archer;
    public GameObject warrior;
    public GameObject wizard;

    public GameObject goblin;
    public GameObject fatman;
    public GameObject mermaid;


    private void Awake()
    {


        playerArray = GameObject.Find("Data").GetComponent<CharacterSet>().playerArray;
        

        //foreach (GameObject item in temp)
        //{
        //    PlayerAdd(item);
        //}



        List<GameObject> normalParty = new List<GameObject>();
        normalParty.Add(fatman);
        normalParty.Add(goblin);
        normalParty.Add(fatman);        
        enemyDict.Add((int)EnemyEnum.NORMAL , new List<GameObject>(normalParty) );
        normalParty.Clear();

        //normalParty.Add(goblin);
        normalParty.Add(goblin);
        normalParty.Add(goblin);
        normalParty.Add(fatman);        
        enemyDict.Add((int)EnemyEnum.NORMALHARD,new List<GameObject>(normalParty));
        normalParty.Clear();

        normalParty.Add(goblin);
        enemyDict.Add((int)EnemyEnum.NORMALONE, new List<GameObject>(normalParty));
        normalParty.Add(goblin);
        enemyDict.Add((int)EnemyEnum.NORMALTWO, new List<GameObject>(normalParty));
        normalParty.Add(goblin);
        enemyDict.Add((int)EnemyEnum.NORMALTHREE, new List<GameObject>(normalParty));
        normalParty.Clear();

        //monsterArr.Add(CharacterEnum.GOBLIN);
        //monsterArr.Add(CharacterEnum.GOBLIN);
        //monsterArr.Add(CharacterEnum.GOBLIN);

    }

    // Start is called before the first frame update
    void Start()
    {
        PlayerCreate();
    }

    public void Update()
    {

        if(!isAlreday && BattleManager.isBattleOn)
        {
            isAlreday=true;
            Debug.Log("monster Create");
            MonsterCreate();
        }

        if (!BattleManager.isBattleOn)
            isAlreday = false;

        if(BattleManager.playerArray.Count <= 0)
        {
            SceneManager.LoadScene("End");
            BattleManager.isBattleOn = false;
            isAlreday = false;
        }
            
        
    }



    public void PlayerAdd (GameObject player)
    {

        if(playerArray.Count >= maxPlayerCapa)
        {
            Debug.Log("over Player List");
            return;
        }
        playerArray.Add(player);
        
    }


    public void PlayerCreate()
    {

        GameObject obj = null;

        for(int i = 0; i < playerArray.Count; i++)
        {
            obj = Instantiate(playerArray[i], playerPos[i]);
            battleManager.PlayerAdd(obj.GetComponent<Player>());

        }


    }

    public void MonsterCreate ()
    {
        GameObject obj = null;
        currentEnemyParty = UnityEngine.Random.Range((int)enemyEnums[0] , (int)enemyEnums[enemyEnums.Length-1]);
        List<GameObject> enemyParty = new List<GameObject>(enemyDict[currentEnemyParty]);


        for (int i = 0; i< enemyParty.Count ; i++)
        {
            obj = Instantiate(enemyParty[i], monsterpos[i]);
            battleManager.EnemyAdd(obj.GetComponent<Enemy>());
        }
        


        BattleManager.instance.CurCharacter.isMyTurn = false;
        battleManager.InitBattle();
    }

}
