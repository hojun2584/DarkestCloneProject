using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum CharacterEnum
{
    ARCHER = 0,
    WARRIOR,
    WIZARD,
    GOBLIN,
    GHOST,
    MERMAID
}


public class CharacterManager : MonoBehaviour
{

    [SerializeField]
    Transform[] playerPos = new Transform[3];

    [SerializeField]
    Transform[] monsterpos = new Transform[3];

    int maxPlayerCapa = 3;
    int maxMosterCapa = 3;

    List<CharacterEnum> playerArr = new List<CharacterEnum>();
    List<CharacterEnum> monsterArr = new List<CharacterEnum>();

    [SerializeField]
    public BattleManager battleManager;



    public CharacterData archerData;
    public GameObject archer;

    public CharacterData warriorData;
    public GameObject warrior;

    public CharacterData wizzardData;
    public GameObject wizard;


    public CharacterData goblinData;
    public GameObject goblin;


    private void Awake()
    {
        PlayerAdd(CharacterEnum.ARCHER);
        PlayerAdd(CharacterEnum.ARCHER);
        PlayerAdd(CharacterEnum.ARCHER);
        monsterArr.Add(CharacterEnum.GOBLIN);
        monsterArr.Add(CharacterEnum.GOBLIN);
        monsterArr.Add(CharacterEnum.GOBLIN);
        
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayerCreate();
        MonsterCreate();

    }


    public void PlayerAdd (CharacterEnum charEnum)
    {

        if(playerArr.Count >= maxPlayerCapa)
        {
            Debug.Log("over Player List");
            return;
        }
        playerArr.Add(charEnum);
        
    }


    public void PlayerCreate()
    {

        Player obj = null;

        for(int i = 0; i < playerArr.Count; i++)
        {
            switch (playerArr[i])
            {
                case CharacterEnum.ARCHER:
                    obj = Instantiate(archer,playerPos[i]).GetComponent<Player>();
                    break;
                case CharacterEnum.WARRIOR:
                    obj = Instantiate(warrior, playerPos[i]).GetComponent<Player>();
                    //obj.CharData = warriorData.CloneObj; 여기 버그 날듯 체크해볼 것
                    break;
                case CharacterEnum.WIZARD:
                    obj = Instantiate(wizard, playerPos[i]).GetComponent<Player>();
                    obj.CharData = wizzardData.CloneObj;
                    break;
            }
            battleManager.AddPlayer(obj);
        }
        
        
    }

    public void MonsterCreate ()
    {
        Enemy obj = null;

        for(int i = 0; i< monsterArr.Count ; i++)
        {
            switch (monsterArr[i])
            {
                case CharacterEnum.GOBLIN:
                    obj = Instantiate(goblin, monsterpos[i]).GetComponent<Enemy>();
                    obj.CharData = goblinData.CloneObj;
                    break;
                case CharacterEnum.WARRIOR:
                    obj = Instantiate(warrior, monsterpos[i]).GetComponent<Enemy>();
                    break;
                case CharacterEnum.WIZARD:
                    obj = Instantiate(wizard, monsterpos[i]).GetComponent<Enemy>();
                    break;
            }
            battleManager.AddEnemy(obj);
        }

    }

}
