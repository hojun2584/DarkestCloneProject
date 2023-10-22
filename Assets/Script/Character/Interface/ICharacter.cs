using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter
{
    public CharacterData CharData 
    { 
        get;
    }

}

public interface IHitAble
{

    public abstract void Hit(float damage);
}


public interface iDieAble : IHitAble
{
    public abstract void Die();
}


public interface IStategy
{
    

}


public interface ISkillUseStrategy
{
    public WeaponData WeaponData { get; set; }

    public abstract void SkillStategy(ICharacter target);

}
public interface IDieStrategy
{
    public abstract void DieStartegy();
}

public interface IHitStrategy
{
    public abstract void HitStartegy(float damage);
}

public interface IFightAble : IHitAble, ISkillUseStrategy , iDieAble
{
    
}

