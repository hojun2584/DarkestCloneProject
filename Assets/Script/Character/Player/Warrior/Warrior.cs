using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Player
{


    public new void Awake()
    {
        base.Awake();
        skills.Add(new BowAttack(this,SKILL.ARROWATTACK));
        skills.Add(new GuardSkill(this,SKILL.GUARD ) );
    }


    public void Start()
    {
        
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
