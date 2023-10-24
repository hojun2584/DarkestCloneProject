using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowAttack : IAttackStrategy
{

    public BowAttack(Character owner)
    {
        this.owner = owner;
    }
    
    public Character Owner 
    {
        get 
        {
            return owner;
        }
    }
    Character owner;

    public float Damage 
    {
        get
        {
            return (owner.CharData.AttackPoint * 0.5f) + (owner.CharData.Speed);
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
