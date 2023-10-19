using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : IAttackStartegy
{

    SwordAttack(WeaponData data)
    {
        this.data = data;
    }
    public WeaponData Data
    {
        get;
        set;
    }
    WeaponData data;

    public float AttackPoint 
    {
        get
        {

            //!!TODOLIST damage calculating
            return (float)data.AttackPoint;
        }
        set
        {
            data.AttackPoint = (int)value;
        }
    }

    public void AttackStartegy(iDieAble target)
    {
        target.Hit(AttackPoint);
    }
}
