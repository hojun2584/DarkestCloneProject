using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

public class BattleManager : SingleTon<BattleManager>
{

    public Re_CharacterManager chManager;

    public List<Player> playerArray = new List<Player>();
    public List<Enemy> enemyArray = new List<Enemy>();
    List<Character> characterList;
    
    int current = 0;

    public ISkillStrategy skill;

    [SerializeField]
    GameObject shopObject;


    public event Action startBattle;
    public event Action endBattle;
    public event Action endGame;
    public event Action setCurrentChar;

    int count = 0;


    bool isBattleOn = false;
    public bool IsBattleOn 
    {
        get => isBattleOn;
        set 
        {
            if (value)
                count++;
            
            if(value && count == playerArray.Count)
            {
                startBattle();
                count = 0;
            }

            isBattleOn = value;
        }
    }


    public Character CurCharacter
    {
        get => curCharacter;
        set
        {
            if(curCharacter != null)
                curCharacter.isMyTurn = false;

            curCharacter = value;
            curCharacter.isMyTurn = true;

            setCurrentChar();
        }
    }
    Character curCharacter;

    public Character Target 
    {
        get => target;
        set
        {
            if(skill!= null)
            {
                skill.UseSkill(value);
                skill = null;
                NextCharacter();
                return;
            }
            target = value;
        }
    }
    Character target;



    public void NextCharacter()
    {

        if (CurCharacter != null)
        {
            current = current < characterList.Count - 1 ? current + 1 : 0;
        }

        CurCharacter = characterList[current];
    }

    public void EndBattle()
    {
        Debug.Log("endBattle");
        isBattleOn = false;
        CurCharacter = characterList[0];
        skill = null;
        shopObject.SetActive(true);
    }


    public void DieCharacter(Character dieChar)
    {
        if (dieChar is Player)
            playerArray.Remove((Player)dieChar);
        else
            enemyArray.Remove((Enemy)dieChar);

        characterList.Remove(dieChar);
        NextCharacter();
    }

    private new void Awake()
    {
        base.Awake();
        characterList = new List<Character>();
        playerArray = new List<Player>();
        enemyArray = new List<Enemy>();

        current = 0;
        

    }


    public void Start()
    {
        initCharacterList();
        
        startBattle += InitBattle;

        StartCoroutine( WaitPlayerDead() );
        endBattle += EndBattle;
    }



    void initCharacterList()
    {
        foreach (var player in playerArray)
        {
            characterList.Add(player);
        }
        SetTurnOrder();
    }

    void SetTurnOrder()
    {
        characterList = characterList.OrderByDescending(character => character.CharData.Speed).ToList();
        CurCharacter = characterList[current];
    }

    IEnumerator WaitEndBattle()
    {
        yield return new WaitUntil( ()=> enemyArray.Count <= 0);
        endBattle();
    }

    IEnumerator WaitPlayerDead()
    {
        yield return new WaitUntil(() => playerArray.Count <= 0);
        endGame();
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


    public void InitBattle()
    {
        current = 0;
        SetTurnOrder();
        StartCoroutine(WaitEndBattle());
    }



}
