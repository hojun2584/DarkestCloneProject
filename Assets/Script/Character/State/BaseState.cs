using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState
{
    protected Fsm stateMachine;

    protected BaseState(Fsm stateMachine)
    {
        this.stateMachine = stateMachine;
    }


    public abstract void SetState(BaseState nextState);
    public abstract void EnterState();
    public abstract void UpdateState();
    public abstract void ExitState();
    


}
