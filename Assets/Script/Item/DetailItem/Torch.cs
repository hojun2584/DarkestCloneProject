using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : Item, IConsumeAbleItem
{

    const int lightValue = 30;

    public Torch(ItemData data)
        :base(data)
    {
    }

    public override void Use(Character user , Character target)
    {
        Cunsume();
    }

    public void Cunsume(Character character = null)
    {
        Data.Amount -= 1;
        Enviromental.enviroMental += lightValue;
    }

}