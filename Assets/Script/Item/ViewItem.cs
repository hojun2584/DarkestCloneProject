using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ViewItem : MonoBehaviour
{


    TextMeshProUGUI itemInfoText;
    public ItemInfoSt ItemInfo 
    {
        get => iteminfo;
        set
        {
            iteminfo = value;
            ViewInfo(iteminfo);
        }
    }
    ItemInfoSt iteminfo;


    private void Awake()
    {
        itemInfoText = GetComponentInChildren<TextMeshProUGUI>();   
    }

    public void ViewInfo(ItemInfoSt iteminfo)
    {
        //��... �̰� ��� ó���Ѵ�...
        itemInfoText.text = iteminfo.name +"\n"+ iteminfo.amount;
    }




}
