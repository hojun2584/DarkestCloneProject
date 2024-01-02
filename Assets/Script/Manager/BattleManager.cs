using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

public class BattleManager : SingleTon<BattleManager>
{

    public CharacterManager chManager;


    
    public List<Player> playerArray = new List<Player>();
    public List<Enemy> enemyArray = new List<Enemy>();
    List<Character> characterList;
    // 전투가 끝나고 다시 전투 들어 갈 때 초기화 어디선가 해줘야함
    // 상태머신 바꾸면서 초기화 해주는 것도 나쁘지 않을 지도?
    int current = 0;

    public ISkillStrategy skill;

    [SerializeField]
    GameObject shopObject;

    [SerializeField]
    ViewStatus status;

    public event Action endBattle;
    public event Action endGame;

    public bool isBattleOn = false;

    public Character CurCharacter
    {
        get => curCharacter;
        set
        {

            curCharacter.isMyTurn = false;
            curCharacter = value;
            curCharacter.isMyTurn = true;

            if (CurCharacter is Player)
                status.Data = CurCharacter.CharData;
        
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
    static Character target;



    public void NextCharacter()
    {

        if (instance.CurCharacter != null)
        {
            current = current < characterList.Count - 1 ? current + 1 : 0;
        }

        instance.CurCharacter = characterList[current];
        
    }


    public void EndBattle()
    {

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

        if (characterList.Count == 0)
        {
            foreach (var player in playerArray)
                characterList.Add(player);

            //foreach (var enemy in enemyArray)
            //    characterList.Add(enemy);
        }

        characterList = characterList.OrderByDescending(character => character.CharData.Speed).ToList();
        CurCharacter = characterList[current];
        CurCharacter.isMyTurn = true;


        StartCoroutine( WaitPlayerDead() );

        endBattle += EndBattle;

    }


    void InitCharList()
    {
        characterList = characterList.OrderByDescending(character => character.CharData.Speed).ToList();
        CurCharacter = characterList[current];

        CurCharacter.isMyTurn = true;

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
    public bool PlayerAdd(GameObject m_player)
    {
        if(m_player.TryGetComponent<Player>(out Player player))
        {
            playerArray.Add(player);
            return true;
        }
        return false;
    }

    public bool EnemyAdd(Enemy enemy) 
    {
        if (enemy == null)
            return false;

        enemyArray.Add(enemy);
        characterList.Add(enemy);
        return true;
    }

    public bool EnemyAdd(GameObject m_enemy)
    {
        if (m_enemy.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemyArray.Add(enemy);
            characterList.Add(enemy);
            return true;
        }
            
        return false;
    }

    public void InitBattle()
    {
        current = 0;
        InitCharList();
    }



}
