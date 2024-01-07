using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parrying : HitStrategy
{

    const int dodgeMultiple = 2;

    public Parrying(Character owner)
        : base(owner)
    {

    }

    public override void Hit(float damage, ICharacter attacker)
    {
        if (IsDodge(attacker.CharData.Accuracy))
        {
            attacker.Hit(Owner.CharData.AttackPoint, Owner);
            animator.SetTrigger("Counter");

            return;
        }
        Owner.Hp -= damage;
    }

    protected new bool IsDodge(int accuracy, int min = 0, int max = 100)
    {
        int flag = Random.Range(min, max);

        if (flag >= (accuracy - (Owner.CharData.Dodge * dodgeMultiple)) )
        {
            return true;
        }

        return false;
    }



}
