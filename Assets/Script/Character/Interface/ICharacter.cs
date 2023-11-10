using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IHitAble
{
    public abstract void Hit(float damage , Character attacker);
}


public interface iDieAble : IHitAble
{
    public abstract void Die();
}

public interface IHitStrategy
{
    public Character Owner { get; }
    public abstract void Hit(float damage, Character attacker);
}

public interface IHealAble
{
    public abstract void Heal();
}

public interface IDieStrategy
{
    public Character Owner { get;}
    public abstract void Die();
    
}

public interface ISkillUseAble
{
    public abstract void UseSkill(Character target);
}

public interface IFightAble : IHitAble, ISkillUseAble , iDieAble
{
    
}



