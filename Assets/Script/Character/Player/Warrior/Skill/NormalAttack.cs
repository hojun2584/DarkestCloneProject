using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalAttack : PlayerAttack
{

    readonly float multipleDamage = 1.2f;

    public NormalAttack(Character owner, SKILLENUM data) : base(owner,data)
    {
    }

    public override float Damage 
    {
        get
        {
            return (float)owner.CharData.AttackPoint * multipleDamage;
        }
    }

    public override void UseSkill(ICharacter target)
    {

        Attack(target);
    }

    public override void Attack(IHitAble target)
    {

        target.Hit(Damage,owner);
    }

}
