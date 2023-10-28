using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveState : BaseState
{

    static int moveValue = 0;
    static int distance;
    int minRange = 100;
    int maxRange = 500;


    public MoveState(Fsm machine) : base(machine)
    {
        
    }


    public override void EnterState()
    {
        distance = Random.Range(minRange, maxRange)*3;
        moveValue = 0;


        Debug.Log("move enter");
    }

    public override void UpdateState()
    {

        bool backMove = Input.GetKey(KeyCode.A);
        bool isMove = Input.GetKey(KeyCode.D);


        if (isMove)
            moveValue += 1;
        

        aniCompo.SetBool("Move", isMove);
        aniCompo.SetBool("Idle", !isMove);


        if (moveValue >= distance)
        {
            ExitState();
        
            owner.stateMachine = new BattleMachine(stateMachine.owner);
            owner.stateMachine.ChangeState(new BattleIdle(stateMachine));

            BattleManager.isBattleOn = true;
        }



    }

    public override void ExitState()
    {

        //!!TODOLIST = battle phase 진입 하는거 변수 설정 해서 처리하기
        //stateMachine = new BattleMachine(owner);
        aniCompo.SetBool("Move", false);
        aniCompo.SetBool("Idle", true);
    }

}
