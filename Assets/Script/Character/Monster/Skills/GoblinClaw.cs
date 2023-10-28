using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinClaw : AttackStrategy
{


    public GoblinClaw(Character owner) : base(owner)
    {
    }

    public override float Damage { get { return owner.CharData.AttackPoint; } }

    public override void Attack(IHitAble target)
    {
        target.Hit(Damage,owner);
    }

    public override void UseSkill(ICharacter target)
    {
        Attack(target);
    }

    public override void UseSkill(List<ICharacter> targets)
    {
        throw new System.NotImplementedException();
    }
}
