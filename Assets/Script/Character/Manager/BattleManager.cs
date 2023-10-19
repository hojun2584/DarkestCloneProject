using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class BattleManager : SingleTon<BattleManager>
{


    public static List<ICharacter> SortedList 
    {
        get
        {
            if(chars != null)
               chars.Sort((x, y) => x.Data.Speed.CompareTo(y.Data.Speed));

            return chars;
        }
    }
    static List<ICharacter> chars = new List<ICharacter>();


    public static void AddCharacter( ICharacter character )
    {
        chars.Add(character);
    }


    private new void Awake()
    {
        base.Awake();

        chars.Sort( ( x , y ) => x.Data.Speed.CompareTo(y.Data.Speed) );
    }








}
