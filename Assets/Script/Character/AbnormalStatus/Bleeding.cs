using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bleeding : Buff
{

    public int minDamage = 3;
    public int maxDamage = 6;

    public Bleeding(Character owner) : base(owner)
    {

    }

    int GetDamage()
    {
        return Random.Range(minDamage,maxDamage);
    }

    public override void ActiveBuff()
    {

        int damage = GetDamage();

        Owner.Hit(damage,Owner);
        base.ActiveBuff();
    }

}
