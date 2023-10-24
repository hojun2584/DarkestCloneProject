using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : IAttackStrategy
{

    public SwordAttack(Character owner)
    {
        this.owner = owner;
    }

    public Character Owner 
    {
        get { return owner; }
    }
    Character owner;

    public float Damage 
    {
        get
        {
            return (float)owner.CharData.AttackPoint * 1.2f;
        }
    }

    public void UseSkill(ICharacter target)
    {
        Attack(target);
    }

    public void Attack(IHitAble target)
    {
        target.Hit(Damage,owner);
    }
}
