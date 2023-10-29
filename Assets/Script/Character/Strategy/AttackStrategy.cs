using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttackStrategy : IAttackStrategy
{


    public AttackStrategy(Character owner)
    {
        this.owner = owner;
    }

    public SkillData Data
    {
        get
        {
            return data;
        }
    }
    protected SkillData data;
    public abstract float Damage { get;}

    public Character Owner => owner;
    protected Character owner;

    public abstract void UseSkill(ICharacter target);
    public abstract void Attack(IHitAble target);
}
