using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : Item, IConsumeAbleItem
{

    int lightValue = 30;

    public Torch(ItemData data)
    {
        Data = data.CloneObj;        
    }

    public override void Use()
    {
        Cunsume();
    }

    public void Cunsume()
    {
        Data.Amount -= 1;
        Enviromental.enviroMental += lightValue;
    }

}