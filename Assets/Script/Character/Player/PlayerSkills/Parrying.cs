using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parrying : HitStrategy
{
    public Parrying(Character owner)
        : base(owner)
    {

    }

    public override void Hit(float damage, ICharacter attacker)
    {
        if (IsDodge())
        {
            attacker.Hit(Owner.CharData.AttackPoint / 2, Owner);
            return;
        }
        Owner.Hp -= damage;
    }



}
