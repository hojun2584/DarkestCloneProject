using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IButtonAble
{


    public abstract void OnClick();

    public abstract void SetStartegy();
}


public interface IInsertAble : IButtonAble
{
    public abstract void InsertItem();

    public void SetInventory(Inventory inven);
}


public interface IBuyAble : IInsertAble
{
    public abstract void BuyItem();
}

public interface IPopAble : IButtonAble
{
    public abstract void PopItem();
}

public interface ISellAble : IPopAble
{
    public abstract void ISell_Item();
}

public interface IButtonStartegy
{
    public abstract void OnClick();


}