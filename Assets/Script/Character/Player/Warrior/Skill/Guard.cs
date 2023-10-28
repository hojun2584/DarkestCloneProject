using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guard : HitStrategy
{


    int armorMultiple = 2;
    public Guard(Character owner) : base(owner)
    {



    }

    public override void Hit(float damage, ICharacter attacker)
    {

        float armor = Owner.CharData.Armor * armorMultiple;

        if ( damage >= armor)
            Owner.Hit(damage, attacker);



    
        return;
    }

}
