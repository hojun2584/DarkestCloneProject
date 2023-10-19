using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState
{
    protected Fsm stateMachine;

    protected BaseState(Fsm machine)
    {
        stateMachine = machine;
    }

    public abstract void EnterState();
    public abstract void UpdateState();
    public abstract void ExitState();
    


}
