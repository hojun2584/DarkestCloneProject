using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


public enum CharacterEnum
{
    ARCHER,
    WARRIOR,
    WIZARD,
}


public enum EnemyEnum
{
    NORMAL
}

public class CharacterManager : MonoBehaviour
{

    [SerializeField]
    Transform[] playerPos = new Transform[3];

    [SerializeField]
    Transform[] monsterpos = new Transform[3];

    int maxPlayerCapa = 3;
    int maxMosterCapa = 3;

    List<GameObject> playerArray = new List<GameObject>();
    List<GameObject> enemyArray = new List<GameObject>();

    Dictionary<EnemyEnum, List<GameObject> > enemyDict = new Dictionary<EnemyEnum, List<GameObject>>();
    

    public BattleManager battleManager;
    bool isAlreday = false;


    public GameObject archer;
    public GameObject warrior;
    public GameObject wizard;

    public GameObject goblin;
    public GameObject ghost;
    public GameObject mermaid;


    private void Awake()
    {
        PlayerAdd(archer);
        PlayerAdd(archer);
        PlayerAdd(archer);

        List<GameObject> normalParty = new List<GameObject>();
        normalParty.Add(goblin);
        normalParty.Add(goblin);
        normalParty.Add(goblin);

        enemyDict.Add(EnemyEnum.NORMAL , normalParty);

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
            Debug.Log("�� ��ȯ �ϱ�");
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
        Array values = Enum.GetValues(typeof(EnemyEnum));
        System.Random random = new System.Random();
        EnemyEnum randomParty = (EnemyEnum)values.GetValue(random.Next(values.Length));
        List<GameObject> enemyParty = new List<GameObject>(enemyDict[randomParty]);

        for (int i = 0; i< enemyParty.Count ; i++)
        {
            obj = Instantiate(enemyParty[i], monsterpos[i]);
            battleManager.EnemyAdd(obj.GetComponent<Enemy>());
        }

        battleManager.InitBattle();
    }

}