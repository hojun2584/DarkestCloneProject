using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemSlot : MonoBehaviour ,IClickUseAble
{

    
    public Inventory inven = null;
    Image ImageCompo = null;
    public Sprite noneImage;
    public TextMeshProUGUI textMesh;

    public ItemData ItemData 
    {
        get
        {
            return itemData;
        }
        set
        {
            itemData = value;
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

    }

    public void Update()
    {
        InitView();
    }

    private void InitView()
    {
        if (haveItem == null)
        {
            ImageCompo.sprite = noneImage;

            if(textMesh != null)
                textMesh.text = "";

            return;
        }


        ImageCompo.sprite = ItemData.SpriteImage;
        textMesh.text = itemData.ItemName + itemData.Amount;


    }

    public void OnClickUse()
    {
        if (haveItem == null)
            return;


        haveItem.Use();
        if(haveItem.Data.Amount <= 0)
        {
            inven.itemList.Remove(haveItem);
            haveItem = null;
            ImageCompo.sprite = noneImage;
        }



    }

}
