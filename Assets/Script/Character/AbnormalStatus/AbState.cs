using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbState
{
    
    protected AbState(Character giver)
    {
        this.giver = this.giver;
    }

    protected int Count 
    {
        get => count;
        set
        {
            count = value;
        }
    }
    int count = 2;

    public Character Giver
    {
        get => giver;
        set
        {
            giver = value;
        }
    }
    Character giver;
    public abstract void Active();
}
