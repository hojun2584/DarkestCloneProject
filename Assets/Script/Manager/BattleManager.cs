using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

public class BattleManager : SingleTon<BattleManager>
{

    public static List<Player> playerArray = new List<Player>();
    public static List<Enemy> enemyArray = new List<Enemy>();
    List<ICharacter> characterList = new List<ICharacter>();
    int current = 0;


    static public ICharacter curCharcter;
    static public ICharacter target;

    public ICharacter aNextCharacter 
    {
        get
        {
            
            current = current < characterList.Count ? current++ : 0;            
            
            ICharacter aliveP =  playerArray.Find(player => player.CharData.Hp <= 0);
            ICharacter aliveE =  enemyArray.Find(enemy => enemy.CharData.Hp <= 0);


            if ( aliveE == null || aliveE == null )
                return null;


            //ICharacter curChar = characterList[ characterList.Keys[current] ];


            return null;
        }    
    }


    private new void Awake()
    {
        base.Awake();
        //chars.Sort( ( x , y ) => x.Data.Speed.CompareTo(y.Data.Speed) );
    }


    public ICharacter NextCharacter()
    {
        // 환형 연결 리스트로 사용 하기 위한 지정자 current
        // list의 Count 보다 커질 시 0으로 초기화
        current = current < characterList.Count ? current++ : 0;

        return characterList[current];
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

    }
    public void Update()
    {
        Debug.Log(curCharcter);
        Debug.Log("player" + playerArray.Count);
        Debug.Log("enemy" + enemyArray.Count);
    }

    public Character GetCurCharacter()
    {

        //curCharacter = SortedList.

        return null;
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
