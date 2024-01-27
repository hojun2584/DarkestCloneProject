using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : IItem
{

    public Item() { }

    public Item(ItemData itemData)
    {
        this.itemData = itemData;
    }

    public ItemData ItemData 
    {
        get
        {
            return itemData;
        } 
    }
    [SerializeField]
    protected ItemData itemData;



    public virtual void Use()
    {

        Debug.Log(itemData.ItemName + " ��� �Ͽ����ϴ�.");

    }
}
