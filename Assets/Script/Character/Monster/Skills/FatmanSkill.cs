using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FatmanSkill : EnemyAttack
{
    const float multipleDamage = 0.5f;

    public override float Damage => Owner.CharData.AttackPoint * multipleDamage;

    public FatmanSkill(Character owner, SKILLENUM data) : base(owner , data)
    {
        
    }

    //bool GetPercent()
    //{

    //    int percent = Random.Range(0, 10);

    //    if (percent < 4)
    //        return false;

    //    return true;
    //}

    public override void UseSkill(ICharacter target)
    {
        DeBuff(target);
        Attack(target);
        animator.SetInteger("Skill" , 1);
    }

    public void DeBuff(ICharacter m_target)
    {
        var target = m_target as Character;
        target.ApplyBuff(new Bleeding(target));
    }

    public override void Attack(IHitAble target)
    {
        target.Hit(Damage, owner);
    }
}
