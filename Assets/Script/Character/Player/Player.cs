using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character , IFightAble
{

    protected  void Awake()
    {
        CharData = CharData.CloneObj;
        hitStrategy = new JustHit(this);
        dieStrategy = new JustDie(this);
        stateMachine = new ExplorerMachine(this);
        stateMachine.ChangeState(new MoveState(stateMachine));


    }


    public int Armor
    {
        get
        {
            
            return CharData.Armor;
        }
        set
        {
            CharData.Armor = value;
        }
    }

    

    public float Power
    {
        get
        {
            return CharData.AttackPoint;
        }
        set
        {
            CharData.AttackPoint = value;
        }
    }

    public float Speed 
    {
        get
        {
            return CharData.Speed;
        }
        set
        {
            CharData.Speed = value;
        }

    }

    public override void Die()
    {
        Debug.Log("정의되지 않은 클래스 player die 호출");
    }

    public new void Update()
    {
        base.Update();
    }

    /// <summary>
    /// 플레이어가 자신에 턴에 들어 왔을 때 초기화 해야 하는 코드 들
    /// </summary>
    public override void EnterTurn()
    {
    }

    public override void Hit(float damage, ICharacter Attacker)
    {
        Debug.Log("정의되지 않은 클래스 player hit 호출");
    }

    public override void UseSkill(ICharacter target)
    {
        Debug.Log("정의되지 않은 클래스 UseSKill 호출");
    }
}
