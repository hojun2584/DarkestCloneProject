using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleIdle : BaseState
{
    
    
    public BattleIdle(Fsm machine) : base(machine)
    {

    }

    public ICharacter Target 
    {
        get
        {
            return BattleManager.target;
        }    
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

        if (owner.selectSkill != null &&Target != null)
            owner.selectSkill.UseSkill(Target);
    }

    



}
