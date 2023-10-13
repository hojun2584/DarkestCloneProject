using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UiButton : MonoBehaviour
{

    
    public UIModel Model 
    { 
        get => model;
        set
        {
            model = value;
        }
    }
    public UIModel model;





    protected void Awake()
    {

        if (model == null)
            model = GameObject.Find("UiModel").GetComponent<UIModel>();

    }

    
}
