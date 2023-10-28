using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerAttack : AttackStrategy
{


    protected Animator animator;

    protected PlayerAttack(Character owner, SKILL data)
        : base(owner)
    {

        this.owner = owner;
        this.data = SKillModel.skillDict[data];
        animator = owner.GetComponent<Animator>();
    }


}
