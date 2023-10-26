using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DieStrategy : IDieStrategy
{
    public Character Owner => owner;
    Character owner;

    protected DieStrategy(Character owner)
    {
        this.owner = owner;    
    }

    public virtual void Die()
    {
        GameObject.DestroyImmediate(owner.CharData);
        GameObject.Destroy(owner.gameObject);

        Debug.Log("dieSt call");
    }
}
