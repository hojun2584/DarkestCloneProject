using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HitStrategy : IHitStrategy
{

    public HitStrategy(Character owner)
    {
        this.owner = owner;
    }
    public Character Owner { get => Owner; }
    Character owner;

    protected bool IsDodge(int min = 0, int max = 100)
    {

        int flag = Random.Range(min, max);

        if (0 < flag && flag < Owner.CharData.Dodge)
            return true;

        return false;
    }

    public abstract void Hit(float damage, ICharacter target);
    


}
