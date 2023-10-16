using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : Item, IConsumeAbleItem
{

    int lightValue = 30;

    public Torch(ItemData data)
    {
        itemData = data;
    }

    public override void Use()
    {
        Cunsume();
    }

    public void Cunsume()
    {
        ItemData.Amount -= 1;
        Enviromental.enviroMental += lightValue;
    }

}