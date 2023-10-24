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

public abstract class Character : MonoBehaviour, ICharacter
{
    protected List<ISkillStrategy> skills = new List<ISkillStrategy>();
    public ISkillStrategy selectSkill;
    public IHitStrategy hitStrategy;
    public IDieStrategy dieStrategy;
    protected EQUIPWEAPON weaponType;

    [SerializeField]
    protected Image hpBar;





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

    public float Hp
    {
        set
        {
            hpBar.fillAmount = (float)CharData.MaxHp / (float)value;
            CharData.Hp = value;
        }
        get
        {
            return charterData.Hp;
        }
    }


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


    public abstract void EnterTurn();

    public abstract void Hit(float damage, ICharacter Attacker);

    public abstract void Die();

    public abstract void UseSkill(ICharacter target);

}