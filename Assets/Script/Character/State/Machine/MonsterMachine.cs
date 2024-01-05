using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMachine : StateMachine
{
    public MonsterMachine(Character owner) : base(owner)
    {
        curState = new MonsterBattleIdle(this);
    }

}
