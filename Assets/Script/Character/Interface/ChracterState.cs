using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChracterState
{

    protected Character owner;

    public ChracterState(Character owner)
    {
        this.owner = owner;
    }


    public virtual ChracterState State 
    { 
        get;
        set;
    }
    public virtual void ActiceState() { }
    public virtual void ExitState() { }
    public virtual void EventOutState() { }

}
