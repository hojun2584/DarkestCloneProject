using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    List<IItem> itemList = new List<IItem>();
    [SerializeField]
    List<GameObject> planeList = new List<GameObject>();

    [SerializeField]
    public bool IsCapacity
    {
        get
        {
            if (itemList.Count < planeList.Count)
                return true;

            return false;
        }
    }
    


    // Start is called before the first frame update
    void Start()
    {
        itemList.Capacity = planeList.Count;
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public Item FindItem(Item item)
    {
        return (Item)itemList.Find(x => x.Iteminfo.name == item.ItemName && x.Iteminfo.amount < x.Iteminfo.maxAmount);
    }

    public bool InsertItem(Item item)
    {

        //var temp = itemList.Find(x => x.InfoItem.ItemName == setItem.InfoItem.ItemName && x.InfoItem.Amount < x.InfoItem.Capacity);
        
        Item iter = (Item)itemList.Find(x => x.Iteminfo.name == item.ItemName && x.Iteminfo.amount < x.Iteminfo.maxAmount);
        
        if(iter != null)
        {
            iter.Amount += 1;
        }
        else if ( IsCapacity )
        {
            itemList.Insert(itemList.Count, item);
            Debug.Log(itemList.Count);
        }


        InitViewItem();
        return false; ;
    }

    public void InitViewItem()
    {

        for (int i = 0; i < planeList.Count; i++)
        {
            if (i > itemList.Count)
                break;

            if (planeList[i].TryGetComponent<ViewItem>(out ViewItem temp))
                temp.ItemInfo = itemList[i].Iteminfo;
        }
    }




    


}
