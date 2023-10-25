using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemSlot : MonoBehaviour ,IClickUseAble
{

    
    public Inventory inven = null;
    Image ImageCompo = null;
    public Sprite noneImage;

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


    private void Start()
    {
        if (!gameObject.TryGetComponent<Image>(out ImageCompo))
            Debug.Log("이미지 컴포넌트 없음" + gameObject.name);

        inven.itemSlotList.Insert(inven.itemSlotList.Count,this);
    }

    private void InitView()
    {
        if (haveItem == null)
        {
            ImageCompo.sprite = noneImage;
        }


        ImageCompo.sprite = ItemData.SpriteImage;
    }

    public void OnClickUse()
    {
        if (haveItem == null)
            return;


        haveItem.Use();
        if(haveItem.Data.Amount <= 0)
        {

            Debug.Log(haveItem.Data.Amount);
            inven.itemList.Remove(haveItem);
            haveItem = null;
            ImageCompo.sprite = noneImage;
        }



    }

}
