using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleMachine : Fsm
{

    public BattleMachine(Character owner) : base(owner)
    {
        curState = new BattleIdle(this);
    }

    



}
