using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BuffStrategy : IBuffStrategy
{

    public int count = 0;

    public BuffStrategy(Character owner)
    {
        this.owner = owner;
    }
    public Character Owner { get { return owner; } }
    Character owner;

    public bool IsSame(BuffStrategy other)
    {
        return other != null && GetType() == other.GetType();
    }

    public virtual BuffStrategy IsAlready()
    {
        var buff = owner.buffs.Find(x => x.IsSame(this) );

        return buff;
    }

    public abstract void UseSkill(ICharacter target);

    public virtual void Buff(ICharacter target, int count = 1)
    {
        Character buffTarget = target as Character;

        BuffStrategy buff = IsAlready();
        buff.count += count;
    }

    public virtual void ActiveBuff() 
    {
        BuffStrategy buff = IsAlready();
        buff.count -= 1;
        if (buff.count <= 0)
            Owner.buffs.Remove(Owner.buffs.Find(x => IsSame(this)));
    }



}
