using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hojun;
using System.Buffers;

public class MonsterBattle : State
{

    int attack = 0;
    float waitNextTime = 3.0f;

    protected Enemy owner;
    protected Animator aniCompo;

    public MonsterBattle(IStateMachine machine) : base(machine)
    {
        owner = (Enemy)machine.GetOwner;

    }

    public override void EnterState()
    {

        
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

        if(BattleManager.instance.CurCharacter == owner) 
        {
            yield return null;
            aniCompo.SetBool("Attack", true);
            yield return null;
            aniCompo.SetBool("Attack", false);

            int targetIter = Random.Range(0, BattleManager.instance.playerArray.Count);
            int useSkill = Random.Range(0, owner.skills.Count);
            owner.skills[useSkill].UseSkill(BattleManager.instance.playerArray[targetIter]);
            aniCompo.SetInteger("Skill", useSkill);

            BattleManager.instance.NextCharacter();
            owner.stateMachine.ChangeState(new MonsterBattleIdle(owner.stateMachine));
        }
        owner.stateMachine.ChangeState(new MonsterBattleIdle(owner.stateMachine));

    }



}
