using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character , IFightAble
{


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
        Debug.Log("���ǵ��� ���� Ŭ���� player die ȣ��");
    }


    /// <summary>
    /// �÷��̾ �ڽſ� �Ͽ� ��� ���� �� �ʱ�ȭ �ؾ� �ϴ� �ڵ� ��
    /// </summary>
    public override void EnterTurn()
    {
    }

    public override void Hit(float damage, ICharacter Attacker)
    {
        Debug.Log("���ǵ��� ���� Ŭ���� player hit ȣ��");
    }

    public override void UseSkill(ICharacter target)
    {
        Debug.Log("���ǵ��� ���� Ŭ���� UseSKill ȣ��");
    }
}
