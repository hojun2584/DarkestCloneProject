using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

public class BattleManager : SingleTon<BattleManager>
{

    public List<Player> playerArray = new List<Player>();
    public List<Enemy> enemyArray = new List<Enemy>();
    static List<Character> characterList = new List<Character>();
    // 전투가 끝나고 다시 전투 들어 갈 때 초기화 어디선가 해줘야함
    // 상태머신 바꾸면서 초기화 해주는 것도 나쁘지 않을 지도?
    static int current = 0;

    public static Character CurCharacter
    {
        get => curCharcter;
        set
        {

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

    public void InitBattle()
    {
        current = 0;
    }

    public void AddPlayer(Player player)
    {
        playerArray.Add(player);
    }

    public void AddEnemy(Enemy enemy)
    {
        enemyArray.Add(enemy);
    }


}
