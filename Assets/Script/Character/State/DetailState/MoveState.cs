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

        aniCompo.SetBool("BackMove" , backMove);
        aniCompo.SetBool("Idle", !backMove);


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

        
        aniCompo.SetBool("Move", false);
        aniCompo.SetBool("Idle", true);
    }

}
