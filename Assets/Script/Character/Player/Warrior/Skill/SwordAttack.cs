using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : AttackStrategy
{
    public SwordAttack(Character owner) : base(owner)
    {
    }

    public override float Damage 
    {
        get
        {
            return (float)owner.CharData.AttackPoint * 1.2f;
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

    public override void UseSkill(List<ICharacter> targets)
    {
        throw new System.NotImplementedException();
    }
}
