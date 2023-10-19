using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : CharacterState
{
    
    public MoveState(Character owner , Fsm machine)
        :base(owner , machine)
    { 
    
    }

public override void EnterState()
    {
        aniCompo.SetBool("Move", true);
    }

    public override void ExitState()
    {
        aniCompo.SetBool("Move" , false);
    }

    public override void UpdateState()
    {
        owner.curState = Input.GetKey(KeyCode.D) ? STATE.MOVE : STATE.IDLE;
        owner.curState = Input.GetKey(KeyCode.A) ? STATE.ATTACK: owner.curState;


    }

}
