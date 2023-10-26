using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroySingle : SingleTon<DontDestroySingle>
{

    protected new void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(this);

    }

}
