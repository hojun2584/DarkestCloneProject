using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleState : BaseState
{
    public BattleState(Fsm machine) : base(machine)
    {
    }

    public override void EnterState()
    {
        
        owner.hitStrategy = new JustHit(owner);
        aniCompo.SetBool("Parrying", false);


        Debug.Log("battle mode enter");
    }

    public override void ExitState()
    {
        CorutineRunner.Start(AttackAnim());
        Debug.Log("battle mode out");
    }

    public override void UpdateState()
    {


        if (owner.isMyTurn == false)
            owner.stateMachine.ChangeState(new BattleIdle(stateMachine));

        if (!BattleManager.isBattleOn)
            owner.stateMachine.ChangeState(new MoveState(owner.stateMachine));
        
    }



    IEnumerator AttackAnim()
    {
        yield return null;
        aniCompo.SetBool("Attack", false);
    }


}
