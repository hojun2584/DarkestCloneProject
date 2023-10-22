using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fsm
{
    public BaseState curState;


    public void ChangeState(BaseState nextState)
    {

        if (curState == nextState)
            return;

        if (curState != null)
            curState.ExitState();

        curState = nextState;
        curState.EnterState();
    }

    public void UpdateState()
    {
        if (curState == null)
            return;


        curState.UpdateState();
    }


}
