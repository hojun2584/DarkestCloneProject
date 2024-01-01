using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Item, IEquipeAbleItem
{

    Player owner;
    Inventory inven;


    public Armor(ItemData data ,Inventory inven) : base(data)
    {
        this.inven = inven;
    }

    public ArmorData ArmorInfo 
    {
        get { return (ArmorData)Data; }
    }

    public override void Use(ICharacter user = null, ICharacter target = null)
    {
        base.Use(user, target);
        Equip(BattleManager.instance.CurCharacter);
    }

    bool isEquip;
    bool IsEquip
    {
        get => isEquip;
        set
        {
            isEquip = value;
        }
    }
    public void Equip(ICharacter equipTarget)
    {
        owner = equipTarget as Player;
        Data.Amount -= 1;

        if (owner.equipArmor != null)
        {
            owner.equipArmor.Data.Amount += 1;
            inven.InsertItem((Item)owner.equipArmor);
            owner.equipArmor.UnEquip();
        }
        owner = equipTarget as Player;
        owner.equipArmor = this;
        owner.AttackPoint += ArmorInfo.AttackPoint;
        owner.Speed += ArmorInfo.Spped;
        owner.Critical += ArmorInfo.Critical;
        owner.Hp += ArmorInfo.MaxHp;
        owner.MaxHp += ArmorInfo.MaxHp;
        owner.Dodge += ArmorInfo.Dodge;
        owner.Armor += ArmorInfo.Armor;
    }

    public void UnEquip()
    {
        owner = BattleManager.instance.CurCharacter as Player;
        owner.equipArmor = null;

        owner.AttackPoint -= ArmorInfo.AttackPoint;
        owner.Speed -= ArmorInfo.Spped;
        owner.Critical -= ArmorInfo.Critical;
        owner.Hp -= ArmorInfo.MaxHp;
        owner.MaxHp -= ArmorInfo.MaxHp;
        owner.Dodge -= ArmorInfo.Dodge;
        owner.Armor -= ArmorInfo.Armor;
    }



}
