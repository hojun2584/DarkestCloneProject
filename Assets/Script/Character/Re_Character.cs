using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Hojun;


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

public abstract class Re_Character : MonoBehaviour
{
    public List<ISkillStrategy> skills = new List<ISkillStrategy>();
    public IHitStrategy hitStrategy;
    public IDieStrategy dieStrategy;
    protected EQUIPWEAPON weaponType;
    public bool isMyTurn = false;
    public List<Buff> buffs = new List<Buff>();

    // 내가 현재 턴인지 확인을 위한 이미지 현재턴이면 캐릭터 위에 해당 이미지가 출력
    public Image currentView;


    [SerializeField]
    protected Image hpBar;
    public StateMachine<Character> stateMachine;



    public CharacterData CharData
    {
        get
        {
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
            if (0 >= value)
                dieStrategy.Die();

            CharData.Hp = value;
        }
        get
        {
            return CharData.Hp;
        }
    }




    public void Update()
    {
        float temp = (float)CharData.Hp / (float)CharData.MaxHp;
        hpBar.fillAmount = Mathf.Lerp(hpBar.fillAmount, temp, Time.deltaTime * 1.0f);

    }

    public abstract void EnterTurn();
    public abstract void Die();
    public abstract void UseSkill(ICharacter target);
    public abstract void Hit(float damage, IHitAble attacker);
}