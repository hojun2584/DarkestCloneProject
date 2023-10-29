using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : Character , IFightAble
{



    protected void Awake()
    {
        CharData = CharData.CloneObj;
        hitStrategy = new JustHit(this);
        dieStrategy = new JustDie(this);
        stateMachine = new ExplorerMachine(this);
        stateMachine.ChangeState(new MoveState(this.stateMachine));
    }

    public Armor equipArmor = null;
    public Weapon equipWeapon = null;

    public int CharStatusArmor
    {
        get
        {
            int armor = 0;

            if (equipArmor != null)
                armor += equipArmor.ArmorInfo.Armor;

            return CharData.Armor + armor;
        }
        set{ CharData.Armor = value; }
    }

    public float AttackPoint
    {
        get{ return CharData.AttackPoint; }
        set{ CharData.AttackPoint = value; }
    }

    public float SpAttack
    {
        get { return CharData.SpAttack; }
        set { CharData.SpAttack = value;}
    }

    public float Speed 
    {
        get{ return CharData.Speed;}
        set{ CharData.Speed = value;}
    }
    
    public float Critical 
    {
        get { return CharData.Critical; }
        set { CharData.Critical = value; }
    }

    public float Fear 
    {
        get { return CharData.Fear; }
        set { CharData.Fear = value; }
    }

    public float MaxHp 
    {
        get { return CharData.MaxHp; }
        set { CharData.MaxHp = value; }
    }
    public int Armor
    {
        get { return CharData.Armor; }
        set { CharData.Armor = value; }
    }
    public int Dodge 
    {
        get { return CharData.Dodge; }
        set { CharData.Dodge = value; }
    }


    public override void Die()
    {
        Debug.Log("���ǵ��� ���� Ŭ���� player die ȣ��");
    }

    public new void Update()
    {
        base.Update();
    }

    /// <summary>
    /// �÷��̾ �ڽſ� �Ͽ� ��� ���� �� �ʱ�ȭ �ؾ� �ϴ� �ڵ� ��
    /// </summary>
    public override void EnterTurn()
    {
    }

    public override void Hit(float damage, ICharacter attacker)
    {
        Debug.Log("player hit call");
        hitStrategy.Hit(damage, attacker);
    }

    public override void UseSkill(ICharacter target)
    {
        Debug.Log("���ǵ��� ���� Ŭ���� UseSKill ȣ��");
    }
}
