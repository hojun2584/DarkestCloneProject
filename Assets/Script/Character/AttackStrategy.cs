using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AttackStrategy : ISkillStrategy
{


    public AttackStrategy(Character owner)
    {
        this.owner = owner;
    }

    public SkillData SkillModel
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
