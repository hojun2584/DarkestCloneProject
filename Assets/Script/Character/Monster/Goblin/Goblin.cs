using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemy
{


    public void Awake()
    {
        skills.Add(new GoblinClaw(this));
    }

    public override void Die()
    {
        
    }

    public override void Hit(float damage, ICharacter Attacker)
    {
        
    }

    public override void UseSkill(ICharacter target)
    {
        
    }

    public override void EnterTurn()
    {
        
    }




}
