using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUseAble
{
    public abstract void Use();

}


public interface IItem : IUseAble
{

    public ItemInfoSt Iteminfo { get; }

}

public interface IConsumeAbleItem : IItem
{

    public void Cunsume();
}


public interface InitViewAble
{
    public void Init();


}