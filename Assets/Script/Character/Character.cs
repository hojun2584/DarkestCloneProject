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
    public List<ISkillStrategy> skills = new List<ISkillStrategy>();
    public ISkillStrategy selectSkill;
    public IHitStrategy hitStrategy;
    public IDieStrategy dieStrategy;
    protected EQUIPWEAPON weaponType;
    public bool IsMyTurn = false;
    public List<BuffStrategy> buffs = new List<BuffStrategy>();



    [SerializeField]
    protected Image hpBar;
    public Fsm stateMachine;


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
            if( 0 >= value)
            {

                dieStrategy.Die();

                return;
            }
            
            CharData.Hp = value;
            //hpBar.fillAmount = (float)charterData.Hp / (float)CharData.MaxHp;
        }
        get
        {
            return CharData.Hp;
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


    public void Update()
    {
        float temp = (float)CharData.Hp / (float)CharData.MaxHp;
        hpBar.fillAmount = Mathf.Lerp(hpBar.fillAmount, temp, Time.deltaTime * 1.0f);

    }

    public abstract void EnterTurn();

    public abstract void Hit(float damage, ICharacter Attacker);

    public abstract void Die();

    public abstract void UseSkill(ICharacter target);

}