using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hojun;

public class MonsterMachine<T> : StateMachine<T> where T : class
{
    public MonsterMachine(T owner) : base(owner)
    {

    }

}
