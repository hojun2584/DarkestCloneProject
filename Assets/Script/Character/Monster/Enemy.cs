using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public static float enhencetAtk = 1;
    protected void Awake()
    {
        CharData = CharData.CloneObj;
        hitStrategy = new JustHit(this);
        dieStrategy = new JustDie(this);
        stateMachine = new MonsterMachine(this);
        
        
        currentView.enabled = false;
    }
    public override void Die()
    {

        dieStrategy.Die();

    }

    public new void Update()
    {
        base.Update();
        if (stateMachine != null)
            stateMachine.curState.UpdateState();

        currentView.enabled = isMyTurn;



    }


    public override void Hit(float damage, ICharacter attacker)
    {
        hitStrategy.Hit(damage,attacker);
    }

    public override void UseSkill(ICharacter target)
    {
        
    }
    public override void UseSkill(Character target)
    {
        
    }
}
