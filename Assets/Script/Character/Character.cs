using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Hojun;


public abstract class Character : MonoBehaviour, ICharacter
{
    public List<ISkillStrategy> skills = new List<ISkillStrategy>();
    public ISkillStrategy selectSkill;
    public IHitStrategy hitStrategy;
    public IDieStrategy dieStrategy;
    public bool isMyTurn = false;
    protected List<Buff> buffs = new List<Buff>();

    // 내가 현재 턴인지 확인을 위한 이미지 현재턴이면 캐릭터 위에 해당 이미지가 출력
    public Image currentView;
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

    [SerializeField]
    protected Image hpBar;
    float setHp;
    public event Action hpEvent;

    public float Hp
    {
        set
        {
            if (0 >= value)
                dieStrategy.Die();

            CharData.Hp = value;
            setHp = (float)CharData.Hp / (float)CharData.MaxHp;

            hpEvent();
        }
        get
        {
            return CharData.Hp;
        }
    }

    float preHp = 1f;
    float nextHp;
    const float distance = 0.0001f;

    public void Start()
    {
        hpEvent += () => { StartCoroutine(SetHpBar()); };
    }


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
            hpBar.fillAmount = nextHp;
            preHp = nextHp;
            Debug.Log(preHp);
            yield return null;
        }
    }

    public virtual void ApplyBuff(Buff addBuff)
    {
        Buff buff = IsAlreadyBuff(addBuff);
        if (buff == null)
            buffs.Add(addBuff);
        else
            buff.count += addBuff.count;
    }

    public virtual void RemoveBuff(Buff removeBuff)
    {
        buffs.Remove(buffs.Find(targetBuff => targetBuff.IsSame(removeBuff)));
    }

    public Buff IsAlreadyBuff(Buff findBuff)
    {
        return buffs.Find(x => x.IsSame(findBuff));
    }

    public void ActiveBuffs()
    {
        foreach (var item in buffs)
        {
            item.ActiveBuff();
        }
    }

    public abstract void Die();
    public abstract void UseSkill(ICharacter target);
    public abstract void Hit(float damage, ICharacter attacker);
}