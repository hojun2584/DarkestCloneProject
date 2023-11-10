using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bleeding : AbState
{
    public Bleeding(Character giver) : base(giver)
    {
    }

    public float Damage 
    {
        get
        {
            float min = Giver.CharData.AttackPoint*0.1f;
            float max = 4 + min;
            float damage = Random.Range(min,max);

            return damage;
        }
    }

    public override void Active()
    {
        Giver.Hit(Damage, Giver);
    }
}
