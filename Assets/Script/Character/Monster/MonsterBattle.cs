using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBattle : BaseState
{

    int attack = 0;
    float waitNextTime = 3.0f;
    public MonsterBattle(Fsm machine) : base(machine)
    {
    }

    public override void EnterState()
    {

        Debug.Log(owner);


        for (int i = 0; i < owner.buffs.Count; i++)
            owner.buffs[i].ActiveBuff();



        CorutineRunner.Start(WaitForNext());
    }

    public override void ExitState()
    {
        owner.isMyTurn = false;
        aniCompo.SetBool("Attack" , false);
    }

    public override void UpdateState()
    {
        
    }

    IEnumerator WaitForNext() 
    {
        
        yield return new WaitForSeconds(waitNextTime);

        if(BattleManager.CurCharacter == owner) 
        {
            yield return null;
            aniCompo.SetBool("Attack", true);
            yield return null;
            aniCompo.SetBool("Attack", false);

            int targetIter = Random.Range(0, BattleManager.playerArray.Count);
            int useSkill = Random.Range(0, owner.skills.Count);
            owner.skills[useSkill].UseSkill(BattleManager.playerArray[targetIter]);
            aniCompo.SetInteger("Skill", useSkill);

            BattleManager.NextCharacter();
            owner.stateMachine.ChangeState(new MonsterBattleIdle(owner.stateMachine));
        }
        owner.stateMachine.ChangeState(new MonsterBattleIdle(owner.stateMachine));

    }



}
