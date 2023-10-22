using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Flags]
public enum STATE
{
    IDLE = 0,
    MOVE,
    ATTACK,
    CRITICAL,
    HIT,
    DIE,
}

public enum EQUIPWEAPON
{

    SWORD = 0,
    BOW,
    WAND

}

public class Character : MonoBehaviour, ICharacter, IFightAble
{

    
    protected ISkillUseStrategy skillStartegy;
    protected IDieStrategy dieStartegy;
    protected IHitStrategy hitStartegy;
    protected EQUIPWEAPON weaponType;

    [SerializeField]
    protected Slider hpBar;



    public CharacterData CharData 
    {
        get 
        {
            if (charterData == null)
                return null;

            if (WeaponData == null)
                return charterData;
            
            return charterData;
        }
        set { charterData = value; }
    }
    [SerializeField]
    CharacterData charterData = null;

    public WeaponData WeaponData 
    {
        get 
        {
            return weapon;
        }
        set
        {
            weapon = value;
        }
    }
    public WeaponData weapon;



    public virtual void Hit(float damage)
    {
        hitStartegy.HitStartegy(damage);
    }

    public virtual void Die()
    {
        dieStartegy.DieStartegy();
    }

    public virtual void SkillStategy(ICharacter target)
    {
        skillStartegy.SkillStategy(target);
    }
}