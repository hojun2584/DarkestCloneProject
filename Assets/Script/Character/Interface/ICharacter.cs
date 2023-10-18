using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter
{

    
}

public interface IHitAble
{
    public abstract void Hit(int damage);
}

public interface IAttackAble
{
    public abstract int Attack();
}
public interface IDieAble
{
    public abstract void Die();
}

public interface IFightAble : IHitAble, IDieAble, IAttackAble
{
    
}