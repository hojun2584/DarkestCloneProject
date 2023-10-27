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

        // owner.selectskill 이 뭐냐 에 따라서 anicompo 설정하는 거 해줘야 할듯

        if (owner.IsMyTurn == true)
            stateMachine.ChangeState(new BattleState(stateMachine));



    }

    



}
