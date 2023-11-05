using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState
{
    protected Fsm stateMachine;
    protected Character owner;
    protected Animator aniCompo;

    protected BaseState(Fsm machine)
    {
        stateMachine = machine;
        owner = machine.owner;
        aniCompo = owner.GetComponent<Animator>();

    }

    public abstract void EnterState();
    public abstract void UpdateState();
    public abstract void ExitState();

}
