using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static UnityEditor.Progress;

public class ItemSlot : MonoBehaviour ,IClickUseAble , IExplainAble
{

    
    public Inventory inven = null;
    Image imageCompo = null;
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
    public string Comment
    {
        get
        {
            var commentItem = haveItem as ICommentAble;

            if(commentItem != null)
                return commentItem.Comment;

            return null;
        }
    }

    public Item haveItem;


    private void Start()
    {
        if (!gameObject.TryGetComponent<Image>(out imageCompo))
            Debug.Log("이미지 컴포넌트 없음" + gameObject.name);


        inven.changeItemList += InitView;
    }


    private void InitView()
    {
        if (haveItem == null)
        {
            imageCompo.sprite = noneImage;

            if(textMesh != null)
                textMesh.text = "";

            return;
        }

        Color color = imageCompo.color;
        color.a = 1f;
        imageCompo.color = color;

        imageCompo.sprite = ItemData.SpriteImage;
        textMesh.text = itemData.ItemName +" "+ itemData.Amount;
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
            ItemData = null;
            Color color = imageCompo.color;
            color.a = 0f;
            imageCompo.color = color;
            imageCompo.sprite = noneImage;
        }

        InitView();

    }

    public void ExplainView()
    {
        throw new System.NotImplementedException();
    }
}
