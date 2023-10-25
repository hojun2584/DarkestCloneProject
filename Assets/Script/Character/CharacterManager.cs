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
    int maxMosterCapa = 4;

    List<CharacterEnum> playerArr = new List<CharacterEnum>();
    List<CharacterEnum> monsterArr = new List<CharacterEnum>();


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

        Character obj;

        for(int i = 0; i < playerArr.Count; i++)
        {
            

            switch (playerArr[i])
            {
                case CharacterEnum.ARCHER:
                    var temp = Instantiate(archer,playerPos[i]);
                    

                    break;
                case CharacterEnum.WARRIOR:
                    obj = Instantiate(warrior, playerPos[i]).GetComponent<Character>();
                    obj.CharData = warriorData.CloneObj;
                    break;
                case CharacterEnum.WIZARD:
                    obj = Instantiate(wizard, playerPos[i]).GetComponent<Character>();
                    obj.CharData = wizzardData.CloneObj;
                    break;
            }

        }


        
    }

    public void MonsterCreate ()
    {
        Character obj;

        for(int i = 0; i< monsterArr.Count ; i++)
        {

            switch (monsterArr[i])
            {
                case CharacterEnum.GOBLIN:
                    obj = Instantiate(goblin, monsterpos[i]).GetComponent<Character>();
                    obj.CharData = goblinData.CloneObj;
                    break;
                case CharacterEnum.WARRIOR:
                    obj = Instantiate(warrior, monsterpos[i]).GetComponent<Character>();
                    break;
                case CharacterEnum.WIZARD:
                    obj = Instantiate(wizard, monsterpos[i]).GetComponent<Character>();
                    break;
            }

        }



    }

}
