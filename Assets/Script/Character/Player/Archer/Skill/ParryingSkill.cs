using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParryingSkill : BuffStrategy, ISkillStrategy
{

    public ParryingSkill(Character owner, SKILL data) : base(owner, data)
    {
        animator = owner.gameObject.GetComponent<Animator>();
    }


    public override void UseSkill(ICharacter target)
    {
        Owner.hitStrategy = new Parrying(Owner);
        animator.SetBool("Parrying", true);
    }
}

