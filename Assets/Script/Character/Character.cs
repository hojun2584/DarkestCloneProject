using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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


    protected void Awake()
    {
        
    }

    private void Update()
    {
        
    }

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