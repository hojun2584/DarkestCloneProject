using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherCharacter : Player
{

    

    public new void Awake()
    {
        base.Awake();
    }

    public void Start()
    {


    }

    public void Update()
    {

        stateMachine.UpdateState();

    }

    public void SetSkillStartegy(ISkillStrategy skill)
    {

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
