using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplorerMachine : StateMachine
{

    



    public ExplorerMachine(Character owner) : base(owner)
    {
        ChangeState(new MoveState(this));
    }




}
