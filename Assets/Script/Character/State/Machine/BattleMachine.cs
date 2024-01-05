using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleMachine : StateMachine
{

    public BattleMachine(Character owner) : base(owner)
    {
        curState = new BattleIdle(this);
        BattleManager.isBattleOn = true;

    
    }

    



}
