using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public abstract class Character : MonoBehaviour, ICharacter
{
    public List<ISkillStrategy> skills = new List<ISkillStrategy>();
    public ISkillStrategy selectSkill;
    public IHitStrategy hitStrategy;
    public IDieStrategy dieStrategy;
    protected EQUIPWEAPON weaponType;
    public bool isMyTurn = false;
    public List<BuffStrategy> buffs = new List<BuffStrategy>();


    public Image currentView;


    [SerializeField]
    protected Image hpBar;
    float setHp;

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
            StartCoroutine( SetHpBar() );
        }
        get
        {
            return CharData.Hp;
        }
    }

    float preHp = 1f;
    float nextHp;
    const float distance = 0.001f;

    public bool IsLerp
    {
        get
        {

            nextHp = Mathf.Lerp(hpBar.fillAmount, setHp, Time.deltaTime * 1.0f);

            if (Math.Abs(preHp - nextHp) >= distance)
                return true;

            return false;
        }
    }
    IEnumerator SetHpBar()
    {
        while (IsLerp)
        {
            setHp = (float)CharData.Hp / (float)CharData.MaxHp;
            hpBar.fillAmount = nextHp;
            preHp = nextHp;
            yield return null;
        }
        Debug.Log("Active");
    }



    public abstract void EnterTurn();
    public abstract void Hit(float damage, ICharacter Attacker);

    public abstract void Die();

    public abstract void UseSkill(ICharacter target);

}