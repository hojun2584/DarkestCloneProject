using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter
{
    public CharacterData Data 
    { 
        get;
    }

}

public interface IHitAble
{

    public abstract void Hit(float damage);
}

public interface IAttackAble
{
    public abstract void Attack(iDieAble target);
}

public interface iDieAble : IHitAble
{
    public abstract void Die();
}


public interface IStategy
{
    public abstract void StartegyUse();

}


public interface IAttackStartegy
{
    public WeaponData Data { get; set; }

    public abstract void AttackStartegy(iDieAble target);

}
public interface IDieStartegy
{
    public abstract void DieStartegy();
}

public interface IHitStartegy
{
    public abstract void HitStartegy(float damage);
}

public interface IFightAble : IHitAble, IAttackAble , iDieAble
{
    
}

