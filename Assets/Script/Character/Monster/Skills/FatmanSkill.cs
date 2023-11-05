using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FatmanSkill : AttackStrategy
{



    public FatmanSkill(Character owner) : base(owner)
    {
        
    }

    public override float Damage => throw new System.NotImplementedException();





    bool GetPercent()
    {

        int percent = Random.Range(0, 10);

        if (percent < 4)
            return false;


        return true;
    }


    public override void Attack(IHitAble target)
    {
        
    }

    public override void UseSkill(ICharacter target)
    {
        DeBuff(target);
        var animator = owner.GetComponent<Animator>();

        animator.SetInteger("Skill" , 1);

    }

    public void DeBuff(ICharacter m_target)
    {

        var target = m_target as Character;


        //if (GetPercent())
            target.buffs.Add(new Bleeding(target , SKILL.STUN));
        


    }

}
