using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerAttack : IAttackStrategy
{

    protected PlayerAttack(Character owner)
    {
        this.owner = owner;
    }

    public Character Owner => owner;
    Character owner;

    public abstract void Attack(IHitAble target);

    public abstract void UseSkill(ICharacter target);

}
