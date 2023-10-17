using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUseAble
{
    public abstract void Use();

}


public interface IItem : IUseAble
{

    public ItemData Data { get; }

}

public interface IConsumeAbleItem : IItem
{

    public void Cunsume();
}


public interface InitViewAble
{
    public void Init();
}