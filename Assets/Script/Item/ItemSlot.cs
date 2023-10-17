using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemSlot : MonoBehaviour
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

        Debug.Log(ItemData.Amount + " " + ItemData.MaxAmount);

    }

}
