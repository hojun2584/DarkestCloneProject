using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.GridLayoutGroup;

public class BowAttack : PlayerAttack
{



    public BowAttack(Character owner , SKILL data) : base(owner , data)
    {
        
    }

    public override float Damage
    {
        get
        {
            var damage = (Owner.CharData.AttackPoint * 0.5f) + (Owner.CharData.Speed);

            return damage;
        }
    }
    public override void Attack(IHitAble target)
    {
        animator.SetBool("Attack",true);
        animator.SetInteger("Skill",0);
        target.Hit(Damage,Owner);
    }

    public override void UseSkill(ICharacter target)
    {
        Attack(target);
    }


}
