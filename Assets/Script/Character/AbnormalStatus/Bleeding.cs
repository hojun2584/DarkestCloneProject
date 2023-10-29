using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bleeding : BuffStrategy
{
    public Bleeding(Character owner, SKILL data) : base(owner, data)
    {

        
    }

    int GetDamage()
    {
        
        return Random.Range(3,6);
    }

    public int Count 
    {
        get
        {
            return count;
        }
    }


    public override void UseSkill(ICharacter target)
    {
        Buff(target);
    }

    public override void ActiveBuff()
    {
        Owner.Hit(GetDamage(),Owner);
        base.ActiveBuff();
    }

}
