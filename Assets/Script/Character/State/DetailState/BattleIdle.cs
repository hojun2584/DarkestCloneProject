using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleIdle : BaseState
{
    
    
    public BattleIdle(Fsm machine) : base(machine)
    {

    }


    public override void EnterState()
    {
        
        owner.selectSkill = null;
        


        Debug.Log("battleIdle enter");

    }

    public override void ExitState()
    {
        Debug.Log("battleIdle exit");
    }

    public override void UpdateState()
    {
        if (owner.isMyTurn == true)
            owner.stateMachine.ChangeState(new BattleState(stateMachine));


        if (BattleManager.instance.isBattleOn == false)
            owner.stateMachine.ChangeState(new MoveState(stateMachine));


    }

    



}
