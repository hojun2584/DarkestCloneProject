using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class BattleManager : SingleTon<BattleManager>
{

    public List<Player> playerArray;
    public List<Enemy> enemyArray;
    SortedList<float,ICharacter> characterList = new SortedList<float, ICharacter> ();
    int current = 0;


    public ICharacter NextCharacter 
    {
        get
        {
            if (characterList.Count == 0)
            {
                foreach (var player in playerArray) 
                    characterList.Add(player.CharData.Speed , player);

                foreach (var enemy in enemyArray)
                    characterList.Add(enemy.CharData.Speed, enemy);
            }

            current = current <= characterList.Count ? current += 1 : 1;            
            
            ICharacter aliveP =  playerArray.Find(player => player.CharData.Hp <= 0);
            ICharacter aliveE =  enemyArray.Find(enemy => enemy.CharData.Hp <= 0);


            if ( aliveE == null || aliveE == null )
                return null;


            ICharacter curChar = characterList[characterList.Keys[current]];


            return curChar;
        }    
    }


    private new void Awake()
    {
        base.Awake();
        //chars.Sort( ( x , y ) => x.Data.Speed.CompareTo(y.Data.Speed) );
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
