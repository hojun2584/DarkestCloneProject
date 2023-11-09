using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : IItem
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


    public virtual void Use(ICharacter user = null , ICharacter target = null)
    {
        Debug.Log(itemData.ItemName + " 사용 하였습니다.");
    }
}
