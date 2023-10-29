using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.GridLayoutGroup;

public class GuardSkill : BuffStrategy
{
    public GuardSkill(Character owner, SKILL data) : base(owner, data)
    {
    }

    public override void UseSkill(ICharacter target)
    {

        Owner.hitStrategy = new Guard(Owner);
        animator.SetBool("Parrying", true);
    }


}
