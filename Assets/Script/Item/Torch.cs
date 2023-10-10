using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : Item, IConsumeAbleItem
{




    public Torch(string name = "Torch" , int cost = 30, int amount = 1, int maxAmount = 20) 
    {
        Iteminfo = new ItemInfoSt(name,cost,amount,maxAmount);
    }

    public Torch(ItemInfoSt iteminfo) : base(iteminfo)
    {

    }


    public override void Use()
    {
        Cunsume();
    }


    public void Cunsume()
    {
        Debug.Log("consume");
    }
}
