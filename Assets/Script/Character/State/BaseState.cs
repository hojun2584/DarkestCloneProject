using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState
{
    protected StateMachine stateMachine;
    protected Character owner;
    protected Animator aniCompo;

    protected BaseState(StateMachine machine)
    {
        stateMachine = machine;
        owner = machine.owner;
        aniCompo = owner.gameObject.GetComponent<Animator>();

    }

    public abstract void EnterState();
    public abstract void UpdateState();
    public abstract void ExitState();

}
