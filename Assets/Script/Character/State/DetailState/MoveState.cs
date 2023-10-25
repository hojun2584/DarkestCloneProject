using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveState : BaseState
{
    public MoveState(Fsm machine) : base(machine)
    {

    }

    public override void EnterState()
    {
        
    }

    public override void ExitState()
    {

        //!!TODOLIST = battle phase 진입 하는거 변수 설정 해서 처리하기
        //stateMachine = new BattleMachine(owner);

    }

    public override void UpdateState()
    {

        bool backMove = Input.GetKey(KeyCode.A);
        bool move = Input.GetKey(KeyCode.D);
        
        aniCompo.SetBool("Move", move);
        aniCompo.SetBool("Idle", !move);
        //aniCompo.SetBool("BackMove" , backMove);
        //aniCompo.SetBool("backMove", !backMove);

    }
}
