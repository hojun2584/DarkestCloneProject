using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : IItem
{

    protected Item(ItemData data)
    {
        this.itemData = data.CloneObj;
    }
    public ItemData Data
    {
        get
        {
            return itemData;
        }
        set
        {
            itemData = value;
        }
        
    }
    ItemData itemData;



    public virtual void Use(ICharacter user = null , ICharacter target = null)
    {
        Debug.Log(itemData.ItemName + " 사용 하였습니다.");
    }
}
