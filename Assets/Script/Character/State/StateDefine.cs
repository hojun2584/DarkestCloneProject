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
        // todo list : �ִϸ��̼� �޸��� �� ����
    }
    public override void EventOutState()
    {
        
    }
    public override void ExitState()
    {
        
    }
}