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
        aniCompo.SetBool("Idle" , true);
        owner.selectSkill = null;

        Debug.Log("battleIdle move enter");

    }

    public override void ExitState()
    {
        
    }

    public override void UpdateState()
    {

        // owner.selectskill �� ���� �� ���� anicompo �����ϴ� �� ����� �ҵ�

        if (owner.IsMyTurn == true)
            stateMachine.ChangeState(new BattleState(stateMachine));



    }

    



}
