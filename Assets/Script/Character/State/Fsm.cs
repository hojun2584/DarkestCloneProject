using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fsm
{
    public BaseState curState = null;
    public Character owner;

    protected Fsm(Character owner)
    {
        this.owner = owner;

    }

    public virtual void ChangeState(BaseState nextState)
    {

        if (curState == nextState)
        {
            Debug.Log("??");
            return;
        }

        if (curState != null)
            curState.ExitState();

        curState = nextState;
        curState.EnterState();
    }

    public virtual void UpdateState()
    {
        if (curState == null)
            return;
        curState.UpdateState();
    }


}
