using Hojun;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveState : Hojun.State
{

    static float moveValue = 0;
    static float distance;
    int minRange = 100;
    int maxRange = 500;

    Character owner;
    Animator aniCompo;

    public MoveState(IStateMachine machine) : base(machine)
    {
        owner = (Character)machine.GetOwner;
        aniCompo = owner.GetComponent<Animator>();
    }


    public override void EnterState()
    {

        distance = Random.Range(minRange, maxRange);
        moveValue = 0;
        aniCompo.SetBool("Parrying" , false);
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
            owner.stateMachine = new BattleMachine(owner);
            owner.stateMachine.ChangeState(new BattleIdle(machine));
            BattleManager.instance.IsBattleOn = true;
        }


    }

    public override void ExitState()
    {
        aniCompo.SetBool("Move", false);
        aniCompo.SetBool("Idle", true);
    }

}
