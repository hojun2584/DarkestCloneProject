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


public interface ISkillStrategy
{
    public WeaponData WeaponData { get; set; }

    public abstract float UseSkill(ICharacter target);

}
public interface IDieStrategy
{
    public abstract void UseDie();
}

public interface IHitStrate
{
    public abstract void UseHit(ISkillStrategy attacker);
}

public interface IFightAble : IHitAble, ISkillStrategy , iDieAble
{
    
}

