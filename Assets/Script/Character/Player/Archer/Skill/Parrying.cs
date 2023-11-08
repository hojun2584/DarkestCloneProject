using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.GridLayoutGroup;

public class Parrying : HitStrategy
{
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
            Debug.Log("회피 성공 22");
            return;
        }
        Owner.Hp -= damage;
    }

    protected new bool IsDodge(int accuracy, int min = 0, int max = 100)
    {
        int flag = Random.Range(min, max);

        if (flag >= (accuracy - (Owner.CharData.Dodge * 2)) )
        {
            Debug.Log("회피 성공");
            return true;
        }


        return false;
    }



}
