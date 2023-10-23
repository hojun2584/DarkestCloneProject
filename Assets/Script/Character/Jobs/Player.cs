using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{


    public float Hp
    {
        get
        {
            return CharData.Hp;
        }
        set
        {
            if (value <= 0)
                dieStartegy.UseDie();

            hpBar.value = value / CharData.MaxHp;
        }
    }
    public int Armor
    {
        get
        {
            
            return CharData.Armor;
        }
        set
        {
            CharData.Armor = value;
        }
    }

    public float Power
    {
        get
        {
            return CharData.AttackPoint;
        }
        set
        {
            CharData.AttackPoint = value;
        }
    }

    public float Speed 
    {
        get
        {
            return CharData.Speed;
        }
        set
        {
            CharData.Speed = value;
        }

    }

}
