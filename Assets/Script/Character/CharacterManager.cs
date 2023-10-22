using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum CharacterEnum
{
    ARCHER = 0,
    WARRIOR,
    WIZARD,
    ORC,
    GHOST,
    MERMAID
}


public class CharacterManager : MonoBehaviour
{

    [SerializeField]
    Transform[] pos = new Transform[4];

    int maxPlayerCapa = 3;
    int maxMosterCapa = 4;

    List<CharacterEnum> playerArr = new List<CharacterEnum>();
    List<Character> mostaerArr = new List<Character>();


    public CharacterData archerData;
    public GameObject archer;

    public CharacterData warriorData;
    public GameObject warrior;

    public CharacterData wizzardData;
    public GameObject wizard;

    private void Awake()
    {
        PlayerAdd(CharacterEnum.ARCHER);
        PlayerAdd(CharacterEnum.ARCHER);
        PlayerAdd(CharacterEnum.ARCHER);


    }

    // Start is called before the first frame update
    void Start()
    {

        PlayerCreate();
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


        for(int i = 0; i < playerArr.Count; i++)
        {
            

            switch (playerArr[i])
            {
                case CharacterEnum.ARCHER:
                    Character obj =  Instantiate(archer,pos[i]).GetComponent<Character>();
                    obj.CharData = archerData.CloneObj;

                    break;
                case CharacterEnum.WARRIOR:
                    Instantiate(warrior, pos[i]).GetComponent<Character>();
                    break;
                case CharacterEnum.WIZARD:
                    Instantiate(wizard, pos[i]).GetComponent<Character>();
                    break;
            }
        }


        
    }

    public void MonsterAdd (CharacterEnum charEnum)
    {
        if (playerArr.Count >= maxMosterCapa)
        {
            Debug.Log("over monster List");
            return;
        }

        switch (charEnum)
        {
            case CharacterEnum.ORC:
                break;
            case CharacterEnum.GHOST:
                break;
            case CharacterEnum.MERMAID:
                break;

        }
    }

}
