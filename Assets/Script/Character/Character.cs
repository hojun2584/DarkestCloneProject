using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Hojun;


public abstract class Character : MonoBehaviour, ICharacter
{
    public List<ISkillStrategy> skills = new List<ISkillStrategy>();
    public ISkillStrategy selectSkill;
    public IHitStrategy hitStrategy;
    public IDieStrategy dieStrategy;
    protected EQUIPWEAPON weaponType;
    public bool isMyTurn = false;
    public List<BuffStrategy> buffs = new List<BuffStrategy>();

    // 내가 현재 턴인지 확인을 위한 이미지 현재턴이면 캐릭터 위에 해당 이미지가 출력
    public Image currentView;

    [SerializeField]
    protected Image hpBar;
    float setHp;

    public StateMachine<Character> stateMachine;


    private void Start()
    {
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
            setHp = (float)CharData.Hp / (float)CharData.MaxHp;

            StartCoroutine( SetHpBar() );
        }
        get
        {
            return CharData.Hp;
        }
    }

    float preHp = 1f;
    float nextHp;
    const float distance = 0.0001f;

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

            yield return null;
        }
    }

    public abstract void Die();
    public abstract void UseSkill(ICharacter target);
    public abstract void Hit(float damage, ICharacter attacker);
}