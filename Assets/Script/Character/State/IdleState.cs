using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseState
{

    GameObject gameObject;
    Character owner;
    Animator aniCompo;



    public IdleState(Fsm stateMachine , Character owner)
        : base(stateMachine)
    { 
        this.owner = owner;
        gameObject = owner.gameObject;

        if (!owner.TryGetComponent<Animator>(out aniCompo))
            Debug.Log("not find animator");

    }

    public override void EnterState()
    {
           
    }

    public override void ExitState()
    {
        throw new System.NotImplementedException();
    }

    public override void SetState(BaseState nextState)
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateState()
    {
        throw new System.NotImplementedException();
    }
}
