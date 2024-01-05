using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Player
{


    public new void Awake()
    {
        base.Awake();
        skills.Add(new SwordSkill(this));
        skills.Add(new SwordSkill(this));
        skills.Add(new SwordSkill(this));
        skills.Add(new SwordSkill(this));

    }


    public new void Update()
    {
        base.Update();
        stateMachine.UpdateState();
    }

    public override void Hit(float damage, Character attacker)
    {
        hitStrategy.Hit(damage, attacker);
    }

    public override void UseSkill(Character target)
    {
        
    }





}
