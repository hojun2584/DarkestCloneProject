using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hojun;
    

public class MonsterBattleIdle : State
{
    protected Enemy owner;

    public MonsterBattleIdle(IStateMachine machine) : base(machine)
    {
        owner = (Enemy)machine.GetOwner;
    }

    public override void EnterState()
    {
        Debug.Log("monster battle idle call");
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
