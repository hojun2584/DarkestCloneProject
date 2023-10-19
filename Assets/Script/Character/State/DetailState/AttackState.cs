using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : CharacterState
{


    public AttackState(Character owner , Fsm machine)
        :base(owner , machine)
    {

    }

    public override void EnterState()
    {
        aniCompo.SetBool("Attack" , true);
    }

    public override void ExitState()
    {
        aniCompo.SetBool("Attack", false);
    }

    public override void UpdateState()
    {

        
    }




}
