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
    List<GameObject> enemyArray;

    Dictionary<EnemyEnum, List<GameObject> > enemyDict = new Dictionary<EnemyEnum, List<GameObject>>();
    

    public BattleManager battleManager;

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
            battleManager.PlayerAdd(obj);
        }


    }

    public void MonsterCreate ()
    {
        GameObject obj = null;

        Array values = Enum.GetValues(typeof(EnemyEnum));
        System.Random random = new System.Random();
        EnemyEnum randomParty = (EnemyEnum)values.GetValue(random.Next(values.Length));
        List<GameObject> enemyParty = enemyDict[randomParty];

        for (int i = 0; i< enemyParty.Count ; i++)
        {
            obj = Instantiate(enemyParty[i], monsterpos[i]);
        }


    }

}
