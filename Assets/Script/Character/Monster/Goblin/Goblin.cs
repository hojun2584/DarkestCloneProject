using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemy
{


    public new void Awake()
    {
        base.Awake();
        skills.Add( new GoblinClaw(this) );

    }

    public override void Die()
    {
        
    }

    public override void Hit(float damage, ICharacter Attacker)
    {
        Hp -= damage;
        Debug.Log(Hp);
    }

    public override void UseSkill(ICharacter target)
    {
        
    }

    public override void EnterTurn()
    {
        
    }




}
