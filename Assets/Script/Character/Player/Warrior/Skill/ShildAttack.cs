using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShildAttack : PlayerAttack
{
    public ShildAttack(Character owner, SKILL data) : base(owner, data)
    {

    }

    public override float Damage
    {
        get { return Owner.CharData.AttackPoint * 0.2f; }

    }

    public override void Attack(IHitAble target)
    {
        target.Hit(Damage,owner);
        var stunTarget = target as Character;
        stunTarget.buffs.Add( new Stun(stunTarget , SKILL.STUN) );

    }

    public override void UseSkill(ICharacter target)
    {
        Attack(target);
        Debug.Log("shild Attack");
    }
}
