using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemSlot : MonoBehaviour ,IClickUseAble
{

    
    public Inventory inven = null;

    public ItemData ItemData 
    {
        get
        {
            return itemData;
        }
        set
        {
            itemData = Instantiate((ItemData)value);
            InitView();
        }
    }
    [SerializeField]
    ItemData itemData = null;

    public Item HaveItem
    {
        get
        {
            return haveItem;
        }
        set
        {
            ItemData = value.Data;
            haveItem = value;
        }
    }
    Item haveItem;

    Image spriteCompo = null;

    private void Start()
    {
        if (!gameObject.TryGetComponent<Image>(out spriteCompo))
            Debug.Log("이미지 컴포넌트 없음" + gameObject.name);

        inven.itemSlotList.Insert(inven.itemSlotList.Count,this);
    }

    private void InitView()
    {
        spriteCompo.sprite = ItemData.SpriteImage;
    }

    public void OnClickUse()
    {
        haveItem.Use();
        if(haveItem.Data.Amount <= 0)
            haveItem = null;
        
    }

}
