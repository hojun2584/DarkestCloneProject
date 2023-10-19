using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fsm
{
    protected BaseState state;


    public void ChangeState(BaseState nextState)
    {

        if (state == nextState)
            return;

        if (state != null)
            state.ExitState();

        state = nextState;
        state.EnterState();
    }

    public void UpdateState()
    {
        if (state == null)
            return;


        state.UpdateState();
    }


}
