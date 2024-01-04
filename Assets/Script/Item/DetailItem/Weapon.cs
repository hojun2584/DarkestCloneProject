using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.GridLayoutGroup;

public class Weapon : Item, IEquipeAbleItem
{
    Player owner;
    public WeaponData weaponInfo;
    Inventory inven;

    public Weapon(ItemData data, Inventory inven) : base(data)
    {

        weaponInfo = (WeaponData)data;
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
    bool isEquip;

    public override void Use(ICharacter user = null, ICharacter target = null)
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
        owner.AttackPoint += weaponInfo.AttackPoint;
        owner.Speed += weaponInfo.Spped;
        owner.Critical += weaponInfo.Critical;
        owner.Hp += weaponInfo.MaxHp;
        owner.MaxHp += weaponInfo.MaxHp;
        owner.Dodge += weaponInfo.Dodge;
        owner.Armor += weaponInfo.Armor;

    }

    public virtual void UnEquip()
    {
        
        owner.equipWeapon = null;
        owner.AttackPoint -= weaponInfo.AttackPoint;
        owner.Speed -= weaponInfo.Spped;
        owner.Critical -= weaponInfo.Critical;
        owner.Hp -= weaponInfo.MaxHp;
        owner.MaxHp -= weaponInfo.MaxHp;
        owner.Dodge -= weaponInfo.Dodge;
        owner.Armor -= weaponInfo.Armor;

    }

}
