using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using UnityEngine;

public class BattleManager : SingleTon<BattleManager>
{

    public CharacterManager chManager;

    static public List<Player> playerArray = new List<Player>();
    static public List<Enemy> enemyArray = new List<Enemy>();
    static List<Character> characterList;
    static int current = 0;
    static event Action changeChar;



    [SerializeField]
    GameObject shopObject;
    public static bool isBattleOn = false;

    public static Character CurCharacter
    {
        get => curCharacter;
        set
        {
            if(curCharacter != null)
                curCharacter.isMyTurn = false;
            
            curCharacter = value;
            curCharacter.isMyTurn = true;

            changeChar();
        
        }
    }
    static Character curCharacter;
    public static Character Target 
    {
        get => target;
        set
        {
            if(skill!= null)
            {
                skill.UseSKill(value);
                skill = null;
                NextCharacter();
                return;
            }
            target = value;
        }
    }
    static Character target;
    static public Skill skill;


    [SerializeField]
    ViewStatus status;


    private new void Awake()
    {
        base.Awake();
        characterList = new List<Character>();
        playerArray = new List<Player>();
        enemyArray = new List<Enemy>();
        current = 0;

        characterList.AddRange(playerArray);
    }


    public static void NextCharacter()
    {

        if (CurCharacter != null)
            current = current < characterList.Count - 1 ? current + 1 : 0;
        
        CurCharacter = characterList[current];
    }


    public void EndBattle()
    {

        isBattleOn = false;

        skill = null;
        shopObject.SetActive(true);
    }

    public void Start()
    {

        if (characterList.Count == 0)
        {
            foreach (var player in playerArray)
                characterList.Add(player);

            //foreach (var enemy in enemyArray)
            //    characterList.Add(enemy);
        }

        characterList = characterList.OrderByDescending(character => character.CharData.Speed).ToList();
        CurCharacter = characterList[current];

    }

    public void Update()
    {
        if(CurCharacter is Player)
            status.Data = CurCharacter.CharData;

        if (enemyArray.Count <= 0 && isBattleOn == true)
        {
            EndBattle();
            Debug.Log("endbattleCall");
        }

        if (curCharacter == null)
            CurCharacter = characterList[current];


    }
    void InitCharList()
    {
        characterList.AddRange(enemyArray);
        characterList = characterList.OrderByDescending(character => character.CharData.Speed).ToList();
        CurCharacter = characterList[current];
    }

    public bool PlayerAdd(Player player)
    {
        if (player == null)
            return false;

        playerArray.Add(player);

        return true;
    }

    public bool EnemyAdd(Enemy enemy) 
    {
        if (enemy == null)
            return false;

        enemyArray.Add(enemy);
        characterList.Add(enemy);
        return true;
    }


    public static void DieCharacter(Character dieChar)
    {
        if (dieChar is Player)
            playerArray.Remove((Player)dieChar);
        else
            enemyArray.Remove((Enemy)dieChar);

        characterList.Remove(dieChar);
    }

    public void InitBattle()
    {
        current = 0;
        characterList.AddRange(enemyArray);
        InitCharList();
    }


    public static void AddChange(Action e)
    {
        changeChar += e;
    }
    public static void AddChangeSingle(Action e)
    {
        changeChar -= e;
        changeChar += e;
    }


}
