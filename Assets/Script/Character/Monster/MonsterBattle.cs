using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBattle : BaseState
{

    int attack = 0;
    float waitNextTime = 3.0f;
    public MonsterBattle(StateMachine machine) : base(machine)
    {

    }

    public override void EnterState()
    {

        

        CorutineRunner.Start(WaitForNext());
    }

    public override void ExitState()
    {
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
            aniCompo.SetBool("Attack", true);
            yield return null;
            aniCompo.SetBool("Attack", false);

            int targetIter = Random.Range(0, BattleManager.playerArray.Count);
            int useSkill = Random.Range(0, owner.skills.Count);
            BattleManager.skill = owner.skills[useSkill];
            BattleManager.Target = BattleManager.playerArray[targetIter];
            aniCompo.SetInteger("Skill", useSkill);
        }
        owner.stateMachine.ChangeState(new MonsterBattleIdle(owner.stateMachine));

    }



}
