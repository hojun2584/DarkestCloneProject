using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill : ISkillStrategy
{
    public Skill(Character owner , SKILLENUM data)
    {
        this.owner = owner;
        this.data = SKillModel.skillDict[data];
        animator = owner.GetComponent<Animator>();
    }

    protected Animator animator;

    public SkillData Data
    {
        get
        {
            return data;
        }
    }
    protected SkillData data;

    public Character Owner => owner;
    protected Character owner;

    public abstract void UseSkill(ICharacter target);
}
