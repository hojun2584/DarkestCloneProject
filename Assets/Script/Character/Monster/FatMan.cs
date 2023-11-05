using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatMan : Enemy
{

    public new void Awake()
    {
        base.Awake();
        //skills.Add(new GoblinClaw(this));
        skills.Add(new FatmanSkill(this));


    }


}
