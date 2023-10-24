using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherCharacter : Player
{

    bool isParryingState = false;



    public void Awake()
    {

        hitStrategy = new JustHit(this);
    }

    public void SetSkillStartegy()
    {

    }


    public override void Die()
    {
        dieStrategy.Die();
    }

    public override void Hit(float damage, ICharacter attacker)
    {
        
        hitStrategy.Hit(damage, attacker);
    }

    public override void UseSkill(ICharacter target)
    {
        selectSkill.UseSkill(target);
    }
}
