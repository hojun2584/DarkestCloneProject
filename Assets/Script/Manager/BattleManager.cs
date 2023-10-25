using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

public class BattleManager : SingleTon<BattleManager>
{

    public List<Player> playerArray = new List<Player>();
    public List<Enemy> enemyArray = new List<Enemy>();
    List<Character> characterList = new List<Character>();
    int current = 0;

    static public Character curCharcter;
    static public Character target;

    [SerializeField]
    ViewStatus status;


    private new void Awake()
    {
        base.Awake();
        //chars.Sort( ( x , y ) => x.Data.Speed.CompareTo(y.Data.Speed) );
    }


    public Character NextCharacter()
    {
        
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
        status.Data = curCharcter.CharData;

    }

    public void Update()
    {
        
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
