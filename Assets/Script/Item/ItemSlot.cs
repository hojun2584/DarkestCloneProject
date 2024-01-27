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
            Debug.Log("�̹��� ������Ʈ ����" + gameObject.name);



        inven.itemSlotList.Insert(inven.itemSlotList.Count,this);

    }

    private void InitView()
    {
        Debug.Log(transform.position);
        spriteCompo.sprite = itemData.ItemData.SpriteImage;
        Debug.Log("���� �� �ʱ�ȭ ���ִ� �ڵ�~");
    }

}
