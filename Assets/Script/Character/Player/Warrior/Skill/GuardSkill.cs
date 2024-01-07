using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.GridLayoutGroup;

public class GuardSkill : Skill
{
    public GuardSkill(Character owner, SKILLENUM data) : base(owner, data)
    {
    }


    public override void UseSkill(ICharacter target)
    {
        Owner.hitStrategy = new Guard(Owner);
        animator.SetBool("Parrying", true);
    }


}
