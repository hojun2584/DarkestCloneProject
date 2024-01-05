using Hojun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleIdle : State
{
    Character owner;
    Animator aniCompo;
    
    public BattleIdle(IStateMachine machine) : base(machine)
    {
        owner = (Character)machine.GetOwner;
        aniCompo = owner.GetComponent<Animator>();
    }


    public override void EnterState()
    {
        
        owner.selectSkill = null;
        


        Debug.Log("battleIdle enter");

    }

    public override void ExitState()
    {
        Debug.Log("battleIdle exit");
    }

    public override void UpdateState()
    {
        if (owner.isMyTurn == true)
            owner.stateMachine.ChangeState(new BattleState(machine));


        if (BattleManager.instance.IsBattleOn == false)
            owner.stateMachine.ChangeState(new MoveState(machine));


    }

    



}
