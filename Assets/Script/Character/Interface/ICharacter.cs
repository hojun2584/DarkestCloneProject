using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter : IFightAble
{
    public CharacterData CharData 
    { 
        get;
    }

}

public interface IHitAble
{
    public abstract void Hit(float damage , ICharacter attacker);
}


public interface iDieAble : IHitAble
{
    public abstract void Die();
}



public interface IHitStrategy
{
    public Character Owner { get; }
    public abstract void Hit(float damage, ICharacter attacker);
}

public interface ISkillStrategy
{
    public Character Owner 
    { 
        get;
    }
    
    public abstract void UseSkill(ICharacter target);

    public SkillData SkillModel { get;}
}

public interface IHealAble
{
    public abstract void Heal();
}



public interface IAttackStrategy : ISkillStrategy
{
    public abstract void Attack(IHitAble target);
}

public interface IHealStrategy : ISkillStrategy
{
    public abstract void Heal(IHitAble target);
}

public interface IBuffStrategy : ISkillStrategy
{
    public abstract void Buff(ICharacter target , int count = 1);
}

public interface IDieStrategy
{
    public Character Owner { get;}
    public abstract void Die();
    
}




public interface ISkillUseAble
{
    public abstract void UseSkill(ICharacter target);
}

public interface IFightAble : IHitAble, ISkillUseAble , iDieAble
{
    
}

