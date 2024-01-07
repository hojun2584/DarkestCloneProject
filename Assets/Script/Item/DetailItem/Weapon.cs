using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item, IEquipeAbleItem, ICommentAble
{
    Player owner;
    Inventory inven;

    public new WeaponData Data 
    {
        get
        {
            return (WeaponData)Data;
        }
    }

    public Weapon(WeaponData data, Inventory inven) : base(data)
    {
        this.inven = inven;
    }

    public bool IsEquip
    {
        get
        {
            return isEquip;
        }
        set
        {
            isEquip = value;
        }
    }

    public string Comment 
    {
        get 
        {
            return Data.Comment;
        }
    }

    bool isEquip;

    public override void Use(Character useUser = null, Character target = null)
    {
        Equip(BattleManager.instance.CurCharacter);
    }

    public virtual void Equip(Character equipTarget)
    {
        owner = equipTarget as Player;
        Data.Amount -= 1;

        if (owner.equipWeapon != null)
        {

            owner.equipWeapon.Data.Amount += 1;
            inven.InsertItem((Item)owner.equipWeapon);
            owner.equipWeapon.UnEquip();
            
        }
        owner.equipWeapon = this;
        owner.AttackPoint += Data.AttackPoint;
        owner.Speed += Data.Spped;
        owner.Critical += Data.Critical;
        owner.Hp += Data.MaxHp;
        owner.MaxHp += Data.MaxHp;
        owner.Dodge += Data.Dodge;
        owner.Armor += Data.Armor;

    }

    public virtual void UnEquip()
    {
        
        owner.equipWeapon = null;
        owner.AttackPoint -= Data.AttackPoint;
        owner.Speed -= Data.Spped;
        owner.Critical -= Data.Critical;
        owner.Hp -= Data.MaxHp;
        owner.MaxHp -= Data.MaxHp;
        owner.Dodge -= Data.Dodge;
        owner.Armor -= Data.Armor;

    }

}
