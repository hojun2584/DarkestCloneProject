using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ViewItem : MonoBehaviour, InitAble
{

    TextMeshProUGUI itemInfoText;
    ItemAdapter adapter;

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
        itemInfoText.text = ItemView.ItemName + "\n" + ItemView.Amount;

    }

}
