using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HitStrategy : IHitStrategy
{

    public HitStrategy(Character owner)
    {
        this.owner = owner;
    }
    public Character Owner { get => Owner; }
    Character owner;

    protected bool IsDodge(int accuracy ,int min = 0, int max = 100)
    {

        int flag = Random.Range(min, max) ;

        if (flag >= accuracy - owner.CharData.Dodge)
        {
            Debug.Log("회피 성공");
            return false;
        }
        
            
        return true;
    }

    public abstract void Hit(float damage, ICharacter target);
    


}
