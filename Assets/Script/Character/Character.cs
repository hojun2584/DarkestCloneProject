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

public abstract class Character : MonoBehaviour
{
    public List<Skill> skills = new List<Skill>();
    public Skill selectSkill;
    public HitStrategy hitStrategy;
    public DieStrategy dieStrategy;
    protected EQUIPWEAPON weaponType;
    public bool isMyTurn = false;
    public Image currentView;

    List<AbState> abnormal = new List<AbState>();


    [SerializeField]
    protected Image hpBar;
    public Fsm stateMachine;
    public List<Fsm> smSterategys;


    private void Start()
    {
        smSterategys = new List<Fsm>();

    }
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

    public void AddAbState(AbState abnormal )
    {
        this.abnormal.Add(abnormal);
    }

    public void ActiveState()
    {
        foreach (var state in abnormal)
            state.Active();
    }

    public abstract void Hit(float damage, Character Attacker);

    public abstract void Die();

    public abstract void UseSkill(Character target);

}