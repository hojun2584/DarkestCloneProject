using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeShot : PlayerAttack
{
    public override float Damage => throw new System.NotImplementedException();

    public ChargeShot(Character owner,SKILLENUM data) : base(owner, data)
    {
        
    }

    public override void UseSkill(ICharacter target)
    {
        animator.SetBool("Casting", true);
        
    }

    public override void Attack(IHitAble target)
    {
        throw new System.NotImplementedException();
    }
}
