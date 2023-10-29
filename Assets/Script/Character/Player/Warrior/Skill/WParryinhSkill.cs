using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WParryinhSkill : BuffStrategy
{
    public WParryinhSkill(Character owner, SKILL data) : base(owner, data)
    {

    }

    public override void UseSkill(ICharacter target)
    {
        Owner.buffs.Add(new Bleeding(Owner,SKILL.BLEEDING));
        Owner.hitStrategy = new WParrying(Owner);
        animator.SetBool("Parrying", true);
    }


}
