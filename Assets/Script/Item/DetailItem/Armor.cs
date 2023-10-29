using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Item, IEquipeAbleItem
{

    Player owner;

    public Armor(ItemData data) : base(data)
    {

    }

    public ArmorData ArmorInfo 
    {
        get { return (ArmorData)Data; }
    }

    public override void Use(ICharacter user = null, ICharacter target = null)
    {
        Equip(BattleManager.CurCharacter);
    }

    public void Equip(ICharacter equipTarget)
    {

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

    public void UnEquip(ICharacter unEquipTarget)
    {
        owner = unEquipTarget as Player;
        owner.equipArmor = this;

        owner.AttackPoint -= ArmorInfo.AttackPoint;
        owner.SpAttack -= ArmorInfo.SpAttack;
        owner.Speed -= ArmorInfo.Spped;
        owner.Critical -= ArmorInfo.Critical;
        owner.Hp -= ArmorInfo.MaxHp;
        owner.MaxHp -= ArmorInfo.MaxHp;
        owner.Dodge -= ArmorInfo.Dodge;
        owner.Armor -= ArmorInfo.Armor;
    }



}
