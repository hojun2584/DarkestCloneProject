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
        skills.Add( new BowAttack(this,SKILLENUM.ARROWATTACK) );
        skills.Add( new GuardSkill(this,SKILLENUM.GUARD));
        skills.Add( new ParryingSkill(this,SKILLENUM.PARRYING));
        skills.Add( new ChargeShot(this, SKILLENUM.EXPLOSIONARROW));

    }


    public new void Update()
    {
        base.Update();
        if(stateMachine != null)
            stateMachine.UpdateState();

    }



    public override void Die()
    {
        dieStrategy.Die();
    }

    public override void Hit(float damage, ICharacter attacker)
    {
        
        hitStrategy.Hit(damage, attacker);
    }

    public override void UseSkill(ICharacter target)
    {
        selectSkill.UseSkill(target);
    }

}
