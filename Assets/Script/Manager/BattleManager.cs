using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

public class BattleManager : SingleTon<BattleManager>
{

    public CharacterManager chManager;


    
    static public List<Player> playerArray = new List<Player>();
    static List<Enemy> enemyArray = new List<Enemy>();
    static List<Character> characterList = new List<Character>();
    // 전투가 끝나고 다시 전투 들어 갈 때 초기화 어디선가 해줘야함
    // 상태머신 바꾸면서 초기화 해주는 것도 나쁘지 않을 지도?
    static int current = 0;


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

        if (CurCharacter != null)
        {
            curCharcter.isMyTurn = false;
            current = current < characterList.Count - 1 ? current + 1 : 0;
        }

        CurCharacter = characterList[current];
        curCharcter.isMyTurn = true;
    }


    public bool IsEndBattle()
    {



        Debug.Log("battleEnd");
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

    public void Update()
    {
        if(CurCharacter is Player)
            status.Data = CurCharacter.CharData;


        if (enemyArray.Count <= 0 && isBattleOn == true)
        {
            isBattleOn = false;
            curCharcter = characterList[0];
        }

        if (curCharcter == null)
        {
            CurCharacter = characterList[current];
            curCharcter.isMyTurn = true;
        }
        

            

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
        curCharcter = characterList[current];
        curCharcter.isMyTurn = true;

    }


    void InitCharList()
    {
        characterList = characterList.OrderByDescending(character => character.CharData.Speed).ToList();
        curCharcter = characterList[current];
        curCharcter.isMyTurn = true;
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
