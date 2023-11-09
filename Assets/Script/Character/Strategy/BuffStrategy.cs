using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BuffStrategy : IBuffStrategy
{

    public int count = 0;
    protected Animator animator;


    public BuffStrategy(Character owner, SKILL data)
    {
        this.data = SKillModel.skillDict[data];
        this.owner = owner;
        animator = owner.GetComponent<Animator>();
    }
    public Character Owner { get { return owner; } }
    Character owner;

    public SkillData Data { get => data; }
    SkillData data;

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

        if (buff == null)
            Owner.buffs.Add(this);

        else
            buff.count += 1;
    }

    public virtual void ActiveBuff() 
    {
        BuffStrategy buff = IsAlready();
        buff.count -= 1;
        if (buff.count <= 0)
            Owner.buffs.Remove(Owner.buffs.Find(x => IsSame(this)));
    }

}
