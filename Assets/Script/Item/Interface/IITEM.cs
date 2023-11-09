using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUseAble
{
    void Use(ICharacter user , ICharacter target);

}

public interface IClickUseAble
{
    public abstract void OnClickUse();

}

public interface IItem : IUseAble
{

    public abstract ItemData Data { get; }

}

public interface IConsumeAbleItem : IItem
{

    public abstract void Cunsume(ICharacter cunsumeTarget);
}

public interface IEquipeAbleItem : IItem
{
    public abstract void Equip(ICharacter equipTarget);
    public abstract void UnEquip();

}


public interface InitViewAble
{
    public abstract void InitView();
}