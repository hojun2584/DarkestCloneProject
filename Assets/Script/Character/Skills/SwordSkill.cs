using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSkill : Skill
{

    public float Damage 
    {
        get
        {
            return Owner.CharData.AttackPoint * 0.5f;
        }
    }

    public SwordSkill(Character owner) : base(owner)
    {

        Data = SKillModel.skillDict[SkillViewData.ARROWATTACK];
    }

    public override void UseSKill(Character target)
    {
        target.Hit(Damage, Owner);
        target.AddAbState(new Bleeding( Owner));
    }

    public override void UseSkill(List<Character> targets)
    {
    

    }
}
