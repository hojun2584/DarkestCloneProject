using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemSlot : MonoBehaviour
{

    
    public Inventory inven = null;

    public IItem? ItemData 
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
    IItem? itemData = null;
    
    
    

    Image spriteCompo = null;

    private void Start()
    {
        if (!gameObject.TryGetComponent<Image>(out spriteCompo))
            Debug.Log("이미지 컴포넌트 없음" + gameObject.name);



        inven.itemSlotList.Insert(inven.itemSlotList.Count,this);

    }

    private void InitView()
    {
        Debug.Log(transform.position);
        spriteCompo.sprite = itemData.ItemData.SpriteImage;
        Debug.Log("대충 뷰 초기화 해주는 코드~");
    }

}
