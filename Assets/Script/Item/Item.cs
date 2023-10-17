using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : IItem
{


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
    [SerializeField]
    ItemData itemData;



    public virtual void Use()
    {

        Debug.Log(itemData.ItemName + " 사용 하였습니다.");

    }
}
