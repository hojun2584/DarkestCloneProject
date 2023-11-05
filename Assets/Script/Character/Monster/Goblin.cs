using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemy
{
    public new void Awake()
    {
        base.Awake();
        skills.Add( new GoblinClaw(this) );

    }

}
