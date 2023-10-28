using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBattleIdle : BaseState
{
    public MonsterBattleIdle(Fsm machine) : base(machine)
    {
    }

    public override void EnterState()
    {

    }

    public override void ExitState()
    {
    }

    public override void UpdateState()
    {
        if (owner.isMyTurn == true)
        {
            owner.stateMachine.ChangeState(new MonsterBattle(owner.stateMachine));
        }



    }
}
