using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WParryingSkill : Skill
{
    public WParryingSkill(Character owner, SKILLENUM data) : base(owner, data)
    {

    }

    public override void UseSkill(ICharacter target)
    {
        Owner.hitStrategy = new WParrying(Owner);
        animator.SetBool("Parrying", true);
    }


}
