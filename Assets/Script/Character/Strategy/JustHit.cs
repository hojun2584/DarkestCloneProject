using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustHit : HitStrategy
{
    public JustHit(Character owner) : base(owner)
    {
    }

    public override void Hit(float damage, ICharacter target)
    {
        if (IsDodge())
            return;

        Owner.Hp -= damage;
    }
}