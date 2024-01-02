using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveState : BaseState
{

    static float moveValue = 0;
    static float distance;
    int minRange = 100;
    int maxRange = 500;


    public MoveState(Fsm machine) : base(machine)
    {
        
    }


    public override void EnterState()
    {

        Debug.Log("¿©±â °íÄ¥ °Í");
        distance = Random.Range(minRange, maxRange);
        moveValue = 0;
        aniCompo.SetBool("Parrying" , false);
        Debug.Log("move enter");
    }

    public override void UpdateState()
    {

        bool isMove = Input.GetKey(KeyCode.D);


        if (isMove)
            moveValue += ( 1f / BattleManager.instance.playerArray.Count);
        

        aniCompo.SetBool("Move", isMove);
        aniCompo.SetBool("Idle", !isMove);



        if (moveValue >= distance)
        {
            ExitState();

            owner.stateMachine = new BattleMachine(stateMachine.owner);
            owner.stateMachine.ChangeState(new BattleIdle(stateMachine));

            BattleManager.instance.isBattleOn = true;
        }


    }

    public override void ExitState()
    {

        
        aniCompo.SetBool("Move", false);
        aniCompo.SetBool("Idle", true);
    }

}
