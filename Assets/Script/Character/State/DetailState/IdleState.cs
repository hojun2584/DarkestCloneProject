using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : CharacterState
{

   

    public IdleState(Character owner , Fsm machine)
        : base(owner, machine)
    { 
        
    }

    public override void EnterState()
    {
        aniCompo.SetBool("Idle" , true);
    }

    public override void ExitState()
    {
        aniCompo.SetBool("Idle" , false);
    }

    public override void UpdateState()
    {
        Debug.Log("¼û ½¬´Â Áß");
    }
}
