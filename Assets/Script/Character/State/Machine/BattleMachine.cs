using Hojun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleMachine : StateMachine<Character>
{

    public BattleMachine(Character owner) : base(owner)
    {
        curState = new BattleIdle(this);
    }


}
