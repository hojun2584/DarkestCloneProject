using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum SpriteNumber{

    TORCH = 0,

}



public class Inventory : MonoBehaviour
{

    List<IItem> itemList = new List<IItem>();
    [SerializeField]
    List<GameObject> planeList = new List<GameObject>();

    Dictionary<int, Sprite> spriteDict = new Dictionary<int, Sprite>();

    SpriteNumber spNumber;

    [SerializeField]
    Sprite temp;


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

    public void Awake()
    {
        spriteDict.Add( (int)SpriteNumber.TORCH , temp);
    }


    // Start is called before the first frame update
    void Start()
    {
        itemList.Capacity = planeList.Count;
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
            iter.Amount += 1;
        else if ( IsCapacity )
            itemList.Insert(itemList.Count, item);


        InitViewItem();
        return false; ;
    }

    public void InitViewItem()
    {

        for (int i = 0; i < planeList.Count; i++)
        {

            if (i >= itemList.Count)
                break;

            if (planeList[i].TryGetComponent<ItemAdapter>(out ItemAdapter item))
            {
                if (itemList[i].Iteminfo.amount <= 0)
                    itemList[i] = null;
                else
                    item.Item = (Item)itemList[i];
            }

        }

    }

}