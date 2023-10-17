using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Inventory : MonoBehaviour
{

    List<IItem> itemList = new List<IItem>();
    
    public List<ItemSlot> itemSlotList = new List<ItemSlot>();



    [SerializeField]
    public bool IsCapacity
    {
        get
        {
            if (itemList.Count < itemSlotList.Count)
                return true;

            return false;
        }
    }

    public void Awake()
    {
        
    }


    // Start is called before the first frame update
    void Start()
    {
        itemList.Capacity = itemSlotList.Count;
    }


    public Item FindItem(Item item)
    {

        return (Item)itemList.Find(data => data.Data.ItemName == item.Data.ItemName && data.Data.Amount <= data.Data.MaxAmount);
    }

    public bool InsertItem(Item item)
    {

        //var temp = itemList.Find(x => x.InfoItem.ItemName == setItem.InfoItem.ItemName && x.InfoItem.Amount < x.InfoItem.Capacity);
        

        Item checkItem = FindItem(item);

        if(checkItem != null)
            checkItem.Data.Amount += 1;


        else if ( IsCapacity )
        {
            int index = itemList.IndexOf(null);

            if (index != -1)
            {
                itemList[index] = item;
            }
            else
            {
                itemList.Insert(itemList.Count, item);
            }

        }
        else
            Debug.Log("insert impossible " + gameObject.name + " 플로팅 바 띄어서 더 이상 집어 넣을 수 없음 알리기");
        

        InitViewItem();
        return false; ;
    }

    public void InitViewItem()
    {

        for (int i = 0; i < itemSlotList.Count; i++)
        {

            if (i >= itemList.Count)
                break;

             itemSlotList[i].ItemData = itemList[i].Data;
        }

    }

}