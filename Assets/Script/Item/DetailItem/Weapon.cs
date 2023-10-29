using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item, IEquipeAbleItem
{
    Player owner;
    public WeaponData weaponInfo;


    protected Weapon(ItemData data) : base(data)
    {
        weaponInfo = (WeaponData)data;
    }

    public override void Use(ICharacter user = null, ICharacter target = null)
    {

    }

    public void Equip(ICharacter equipTarget)
    {
        owner = equipTarget as Player;
        owner.equipWeapon = this;

        owner.AttackPoint += weaponInfo.AttackPoint;
        owner.Speed += weaponInfo.Spped;
        owner.Critical += weaponInfo.Critical;
        owner.Hp += weaponInfo.MaxHp;
        owner.MaxHp += weaponInfo.MaxHp;
        owner.Dodge += weaponInfo.Dodge;
        owner.Armor += weaponInfo.Armor;
    }

    public void UnEquip(ICharacter unEquipTarget)
    {
        owner = unEquipTarget as Player;
        owner.equipWeapon = this;

        owner.AttackPoint -= weaponInfo.AttackPoint;
        owner.SpAttack -= weaponInfo.SpAttack;
        owner.Speed -= weaponInfo.Spped;
        owner.Critical -= weaponInfo.Critical;
        owner.Hp -= weaponInfo.MaxHp;
        owner.MaxHp -= weaponInfo.MaxHp;
        owner.Dodge -= weaponInfo.Dodge;
        owner.Armor -= weaponInfo.Armor;

    }
}
