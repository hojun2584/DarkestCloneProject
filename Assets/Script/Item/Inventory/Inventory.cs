using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Inventory : MonoBehaviour
{

    public List<Item> itemList = new List<Item>();
    public List<ItemSlot> itemSlotList = new List<ItemSlot>();
    public event Action changeItemList;

    public bool IsCapacity => (itemList.Count < itemSlotList.Count);


    // Start is called before the first frame update
    void Start()
    {
        itemList.Capacity = itemSlotList.Count;
        changeItemList += InitViewItem;
    }



    public Item FindItem(Item item)
    {
        
        return itemList.Find(data => data.Data.name == item.Data.name &&
                                   data.Data.Amount < data.Data.MaxAmount);
    }

    public bool InsertItem(Item item)
    {

        Item checkItem = FindItem(item);

        if(checkItem != null)
        {
            checkItem.Data.Amount += 1;
        }
        else if ( IsCapacity )
        {
            int index = itemList.IndexOf(null);

            if (index != -1)
                itemList[index] = item;
            else
                itemList.Insert(itemList.Count, item);


            changeItemList();
        }
        else
        {
            // 더 이상 집어 넣을 곳이 없다는 의미
            return false;
        }

        return true;
    }




    public void InitViewItem()
    {

        itemList.RemoveAll(item => item.Data.Amount <= 0);

        for (int i = 0; i < itemSlotList.Count; i++)
        {
            if (i >= itemList.Count)
                break;

             itemSlotList[i].HaveItem = (Item)itemList[i];
        }

    }

}