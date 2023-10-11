using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct ItemInfoSt
{
    public string name;
    public int cost;
    public int amount;
    public int maxAmount;

    public ItemInfoSt(string name , int cost, int amount , int maxAmount)
    {
        this.name = name;
        this.cost = cost;
        this.amount = amount;
        this.maxAmount = maxAmount;
    }
}

public class Item : IItem
{
    protected Item(string name = "none", int cost = 0, int amount = 0, int maxAmount = 0)
    {
        this.iteminfo = new ItemInfoSt(name,cost,amount,maxAmount);
    }

    protected Item(ItemInfoSt iteminfo)
    {
        this.iteminfo = iteminfo;
    }

    public Item(Item item)
    {
        this.iteminfo = item.iteminfo;
    }

    public ItemInfoSt Iteminfo
    {
        get
        {
            return iteminfo;
        }
        protected set
        {
            iteminfo = value;
        }
    }
    ItemInfoSt iteminfo;


    public string ItemName {
       get 
       {
           return iteminfo.name;
       }
    }
    
    public int Cost
    {
        get
        {
            return iteminfo.cost;
        }
    }

    public int Amount
    {
        get
        {
            return iteminfo.amount;
        }
        set 
        {
            iteminfo.amount = value;
        }
    }

    public int MaxAmount
    {
        get
        {
            return iteminfo.maxAmount;
        }
    }

    public virtual void Use()
    {

    }

}