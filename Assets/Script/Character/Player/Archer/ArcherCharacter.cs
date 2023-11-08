using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArcherCharacter : Player
{

    public new void Awake()
    {
        base.Awake();
        //최소 4개는 집어 넣을 것 
        skills.Add( new BowAttack(this,SKILL.ARROWATTACK) );
        skills.Add(new GuardSkill(this,SKILL.GUARD));
        skills.Add( new ParryingSkill(this,SKILL.PARRYING));
        skills.Add(new ChargeShot(this, SKILL.EXPLOSIONARROW));

    }

    public new void Update()
    {
        base.Update();
        if(stateMachine != null)
            stateMachine.UpdateState();
    }



    public override void UseSkill(ICharacter target)
    {
        selectSkill.UseSkill(target);
    }

}
