using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ViewItem : MonoBehaviour, InitViewAble
{

    TextMeshProUGUI itemInfoText;
    ItemAdapter adapter;

    [SerializeField]
    Component textModel;

    public Item ItemView
    {
        get
        {
            return adapter.Item;
        }
    }

    private void Awake()
    {
        itemInfoText = GetComponentInChildren<TextMeshProUGUI>();
        adapter = GetComponent<ItemAdapter>();
        


    }

    private void Start()
    {
        adapter.Initcomponent.Insert(0, this);

    }

    public void Init()
    {
        if (ItemView == null)
        {
            itemInfoText.text = "null";
            return;
        }

        itemInfoText.text = ItemView.ItemName + "\n" + ItemView.Amount;

    }

}
