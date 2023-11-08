using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : IItemAble
{

    public Item(ItemData data)
    {
        this.itemData = data.CloneObj;
    }


    public ItemData Data
    {
        get
        {
            if(itemData == null)
                return null;

            return itemData;
        }
        set
        {
            itemData = value;
        }
        
    }
    public ItemData itemData = null;


    public abstract void Use(Character user = null, Character target = null);
}
