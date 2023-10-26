using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{


    protected  void Awake()
    {
        CharData = CharData.CloneObj;
        hitStrategy = new JustHit(this);
        stateMachine = new MonsterMachine(this);
        stateMachine.ChangeState( new BattleIdle(stateMachine) );
        dieStrategy = new JustDie(this);

    }
    public override void Die()
    {

        dieStrategy.Die();

    }

    public new void Update()
    {
        base.Update();
    }

    public override void EnterTurn()
    {
        throw new System.NotImplementedException();
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
