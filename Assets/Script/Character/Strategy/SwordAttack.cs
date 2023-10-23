using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : ISkillStrategy
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

    public WeaponData WeaponData { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public float UseSkill(ICharacter target)
    {
        throw new System.NotImplementedException();
    }
}
