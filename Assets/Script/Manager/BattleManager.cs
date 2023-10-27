using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

public class BattleManager : SingleTon<BattleManager>
{

    public CharacterManager chManager;


    
    List<Player> playerArray = new List<Player>();
    List<Enemy> enemyArray = new List<Enemy>();
    static List<Character> characterList = new List<Character>();
    // ������ ������ �ٽ� ���� ��� �� �� �ʱ�ȭ ��𼱰� �������
    // ���¸ӽ� �ٲٸ鼭 �ʱ�ȭ ���ִ� �͵� ������ ���� ����?
    static int current = 0;
    bool endBattle;


    public static bool isBattleOn = false;

    public static Character CurCharacter
    {
        get => curCharcter;
        set
        {
            curCharcter = value;
        }
    }
    static Character curCharcter;
    public static Character Target 
    {
        get => target;
        set
        {

            if(skill!= null)
            {
                skill.UseSkill(value);
                skill = null;
                NextCharacter();
                Debug.Log(current);
                return;
            }

            target = value;
        }
    }
    static Character target;
    static public ISkillStrategy skill;


    [SerializeField]
    ViewStatus status;


    private new void Awake()
    {
        base.Awake();
        //chars.Sort( ( x , y ) => x.Data.Speed.CompareTo(y.Data.Speed) );
    }


    public static void NextCharacter()
    {
        current += current < characterList.Count ? 1 : 0;
        CurCharacter = characterList[current];
        curCharcter.IsMyTurn = true;
    }


    public bool IsEndBattle()
    {


        return true;
    }


    public static void DieCharacter(Character dieChar)
    {



    }

    public void Update()
    {
        if (isBattleOn)
        {
            chManager.MonsterCreate();
            isBattleOn = false;
        }

        IsEndBattle();
    }

    public void Start()
    {

        if (characterList.Count == 0)
        {
            foreach (var player in playerArray)
                characterList.Add(player);

            foreach (var enemy in enemyArray)
                characterList.Add(enemy);
        }

        characterList = characterList.OrderByDescending(character => character.CharData.Speed).ToList();
        curCharcter = characterList[current];
        status.Data = curCharcter.CharData;


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
        return true;
    }

    public bool EnemyAdd(GameObject m_enemy)
    {
        if (m_enemy.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemyArray.Add(enemy);
            return true;
        }
            
        return false;
    }

    public void InitBattle()
    {
        current = 0;
    }



}
