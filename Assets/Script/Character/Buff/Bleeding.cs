using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bleeding : BuffStrategy
{
    public Bleeding(Character owner) : base(owner)
    {
    }

    int GetDamage()
    {
        
        return Random.Range(0,5);
    }

    public int Count 
    {
        get
        {
            return count;
        }
    }

    public override void Buff(ICharacter target , int count = 4 )
    {
        Character buffTarget = target as Character;

        BuffStrategy buff = IsAlready();
        buff.count += count;

    }

    public override void UseSkill(ICharacter target)
    {
        ActiveBuff();
    }

    public override void ActiveBuff()
    {
        Owner.Hp -= GetDamage();


        base.ActiveBuff();
    }
}
