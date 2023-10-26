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
    }

    public override void ExitState()
    {
        
    }

    public override void UpdateState()
    {

    }

    



}
