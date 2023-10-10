using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IButtonStartegy
{
    public abstract void OnClick();
}


public interface IInsertAble : IButtonStartegy
{
    public abstract void InsertItem();
    public Item GetItem{ get;}

    public void SetInventory(Inventory inven);
}


public interface IBuyAble : IInsertAble
{
    public abstract void BuyItem();
}

public interface IPopAble : IButtonStartegy
{
    public abstract void PopItem();
}

public interface ISellAble : IPopAble
{
    public abstract void ISell_Item();
}