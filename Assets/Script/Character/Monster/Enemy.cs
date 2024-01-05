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
        stateMachine = new MonsterMachine<Character>(this);
        stateMachine.ChangeState( new MonsterBattleIdle(stateMachine) );

        currentView.enabled = false;
    }
    public override void Die()
    {

        dieStrategy.Die();

    }

    public void Update()
    {
        
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
        //!!TODOLIST require mosnter behavior define!!
        //

    }
}
