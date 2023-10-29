using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WParrying : HitStrategy
{

    float armorMultiple = 1.5f;

    public WParrying(Character owner) : base(owner)
    {

    }

    public override void Hit(float damage, ICharacter attacker)
    {

        float armor = Owner.CharData.Armor * armorMultiple;

        if(damage >= armor)
            Owner.Hit(damage, attacker);

        attacker.Hit(Owner.CharData.Armor, Owner);
        animator.SetTrigger("Counter");

    }
}
