using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Player
{


    public new void Awake()
    {
        base.Awake();
        skills.Add(new BowAttack(this,SKILLENUM.ARROWATTACK));
        skills.Add(new GuardSkill(this,SKILLENUM.GUARD ) );
        skills.Add(new WParryingSkill(this, SKILLENUM.PARRYING));
        skills.Add(new ShildAttack(this,SKILLENUM.SHILDATTACK));
    }


    public new void Update()
    {
        base.Update();
        stateMachine.UpdateState();

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
