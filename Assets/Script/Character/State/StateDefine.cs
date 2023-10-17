using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Run : ChracterState
{

    Animation animCompo;
    Run(Character owner): base(owner)
    {

        if (owner.gameObject.TryGetComponent<Animation>(out animCompo)) ;
        
    }

    public override void ActiceState()
    {
        // todo list : 애니매이션 달리는 거 구현
    }
    public override void EventOutState()
    {
        
    }
    public override void ExitState()
    {
        
    }
}