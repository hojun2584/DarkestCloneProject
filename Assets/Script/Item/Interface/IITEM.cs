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

public interface IItem : IUseAble
{

    public abstract ItemData Data { get; }

}

public interface IConsumeAbleItem 
{

    public abstract void Cunsume(ICharacter cunsumeTarget);
}

public interface ICommentAble
{

    public string Comment { get;}

}


public interface IEquipeAbleItem 
{
    public abstract void Equip(Character equipTarget);
    public abstract void UnEquip();

}


public interface InitViewAble
{
    public abstract void InitView();
}