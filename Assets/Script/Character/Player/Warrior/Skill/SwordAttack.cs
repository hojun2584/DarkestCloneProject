using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : PlayerAttack
{
    public SwordAttack(Character owner, SKILL data) : base(owner , data)
    {
    }

    public override float Damage 
    {
        get
        {
            return (float)owner.CharData.AttackPoint * 1.2f;
        }
    }

    public override void UseSkill(ICharacter target)
    {

        Attack(target);
    }

    public override void Attack(IHitAble target)
    {
        target.Hit(Damage,owner);
    }

}
