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

        owner.hitStrategy = new JustHit(owner);

        Debug.Log("player enter state ???");
        aniCompo.SetBool("Parrying", false);

        for (int i = 0; i < owner.buffs.Count; i++)
            owner.buffs[i].ActiveBuff();
        


        Debug.Log("battle mode enter");
    }

    public override void ExitState()
    {
        CorutineRunner.Start(AttackAnim());
        Debug.Log("battle mode out");
    }

    public override void UpdateState()
    {
        if (owner.isMyTurn == false)
            owner.stateMachine.ChangeState(new BattleIdle(stateMachine));

        if (!BattleManager.instance.isBattleOn)
            owner.stateMachine.ChangeState(new MoveState(owner.stateMachine));
        


    }



    IEnumerator AttackAnim()
    {
        yield return null;
        aniCompo.SetBool("Attack", false);
    }


}
