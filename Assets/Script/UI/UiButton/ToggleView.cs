using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleView : UIText
{


    private new void Start()
    {
        base.Start();
        ModelName = model.Toggle;
        
    }


    public void Update()
    {

        Init();

    }


    public override void Init()
    {
        base.Init();
    }

}
