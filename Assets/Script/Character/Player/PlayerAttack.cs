using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerAttack : Skill
{

    public abstract float Damage { get; }

    protected PlayerAttack(Character owner, SKILLENUM data)
        : base(owner, data)
    {

    }
    public abstract void Attack(IHitAble target);

}
public abstract class EnemyAttack : Skill
{

    public abstract float Damage { get; }

    protected EnemyAttack(Character owner, SKILLENUM data)
        : base(owner, data)
    {
        
    }

    public abstract void Attack(IHitAble target);
}