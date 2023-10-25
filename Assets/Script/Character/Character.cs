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

                // hp 호출하면 바로 오브젝트 destroy 될듯 추후 개발에 따라서 정리 해야 함
                //dieStrategy.Die();

                return;
            }

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