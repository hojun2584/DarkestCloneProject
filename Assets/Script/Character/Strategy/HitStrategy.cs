using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HitStrategy
{

    protected Animator animator;

    public HitStrategy(Character owner)
    {
        this.owner = owner;
        animator = owner.GetComponent<Animator>();
    }
    public Character Owner { get => owner; }
    Character owner;

    protected bool IsDodge(int accuracy ,int min = 0, int max = 100)
    {

        int flag = Random.Range(min, max) ;

        if (flag >= accuracy - owner.CharData.Dodge)
        {
            Debug.Log("ȸ�� ����");
            return true;
        }
        
            
        return false;
    }

    public abstract void Hit(float damage, Character attacker);
    


}
