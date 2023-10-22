using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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




    }

}
