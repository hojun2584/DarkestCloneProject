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
        //List<BuffStrategy> buffs = owner.buffs;

        foreach(BuffStrategy buff in owner.buffs)
            buff.ActiveBuff();


        Debug.Log("battle mode enter");

    }

    public override void ExitState()
    {
        owner.IsMyTurn = false;
    }

    public override void UpdateState()
    {
        
    }
}
