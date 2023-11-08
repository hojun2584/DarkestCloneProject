using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUseAble
{
    void Use(Character user , Character target);

}

public interface IClickUseAble
{
    public abstract void OnClickUse();

}

public interface IItemAble : IUseAble
{
    public abstract ItemData Data { get; }

}

public interface IConsumeAbleItem : IItemAble
{

    public abstract void Cunsume(Character cunsumeTarget);
}

public interface IEquipeAbleItem : IItemAble
{
    public abstract void Equip(Character equipTarget);
    public abstract void UnEquip();

}


public interface InitViewAble
{
    public abstract void InitView();
}