using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleState : BaseState
{
    public BattleState(Fsm machine) : base(machine)
    {
    }

    public override void EnterState()
    {
        List<BuffStrategy> buffs = owner.buffs;

        foreach(BuffStrategy buff in buffs)
            buff.ActiveBuff();
        



    }

    public override void ExitState()
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateState()
    {
        throw new System.NotImplementedException();
    }
}
