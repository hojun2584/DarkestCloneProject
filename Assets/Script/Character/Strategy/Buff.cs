using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Buff : IBuffStrategy
{

    public int count = 0;
    protected Animator animator;


    public Buff(Character owner)
    {
        this.owner = owner;
        animator = owner.GetComponent<Animator>();
    }

    public Character Owner { get { return owner; } }
    Character owner;

    public SkillData Data { get => data; }
    SkillData data;

    public bool IsSame(Buff other)
    {
        return other != null && GetType() == other.GetType();
    }




    public virtual void ActiveBuff() 
    {
        Buff buff = owner.IsAlreadyBuff(this);
        buff.count -= 1;
        if (buff.count <= 0)
            owner.RemoveBuff(buff);
    }

}
