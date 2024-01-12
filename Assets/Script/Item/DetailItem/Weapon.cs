using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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
        isEquip = true;
        ApplyStatus();

    }

    public virtual void UnEquip()
    {
        isEquip = false;
        ApplyStatus();
    }


    private void ApplyStatus()
    {
        int equip = isEquip ? 1 : 0;
        owner.AttackPoint += equip * Data.AttackPoint;
        owner.Speed += equip * Data.Spped;
        owner.Critical += equip * Data.Critical;
        owner.Hp += equip * Data.MaxHp;
        owner.MaxHp += equip * Data.MaxHp;
        owner.Dodge += equip * Data.Dodge;
        owner.Armor += equip * Data.Armor;
    }

}
