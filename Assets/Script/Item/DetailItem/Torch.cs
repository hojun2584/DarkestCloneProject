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

    public override void Use(ICharacter user , ICharacter target)
    {
        Cunsume();
    }

    public void Cunsume(ICharacter character = null)
    {
        Data.Amount -= 1;
        Enviromental.enviroMental += lightValue;
    }

}