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
    protected ISkillStrategy skillStartegy;
    protected IDieStrategy dieStartegy;
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
            charterData.Speed += value.Speed;


            weapon = value;
        }
    }
    public WeaponData weapon;



    public virtual void Die()
    {
        dieStartegy.UseDie();
    }


    public void Hit(float damage)
    {
        throw new NotImplementedException();
    }

    public float UseSkill(ICharacter target)
    {


        return target.CharData.AttackPoint;
    }
}