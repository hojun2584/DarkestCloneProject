using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertButton : IInsertAble
{

    
    Inventory inven;

    public InsertButton(Item item , Inventory inven)
    {
        this.value = item;
        this.inven = inven;
    }
    Item value;

    public UIModel Model { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void InsertItem()
    {
        inven.InsertItem(value);
    }

    public void OnClick()
    {
        InsertItem();
    }

    public void SetInventory(Inventory inven)
    {
        this.inven = inven;
    }

    public void SetStartegy()
    {
        throw new System.NotImplementedException();
    }

}