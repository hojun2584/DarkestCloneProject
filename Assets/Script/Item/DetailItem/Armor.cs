using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Item, IEquipeAbleItem
{

    Player owner;
    Inventory inven;
    
    public Armor(ArmorData data ,Inventory inven) : base(data)
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
    bool isEquip;



    public new ArmorData Data 
    {
        get { return (ArmorData)base.Data; }
    }

    public override void Use(Character user = null, Character target = null)
    {
        Equip(BattleManager.instance.CurCharacter);
    }

    public void Equip(Character equipTarget)
    {
        owner = equipTarget as Player;
        base.Data.Amount -= 1;

        // 플레이어가 이미 장착한 아이템이 있다면
        // 풀어주고(아이템 수량 늘려주고)
        // 인벤 삽입
        if (owner.equipArmor != null)
        {
            owner.equipArmor.Data.Amount += 1;
            inven.InsertItem((Item)owner.equipArmor);
            owner.equipArmor.UnEquip();
        }
        owner.equipArmor = this;
        owner.AttackPoint += Data.AttackPoint;
        owner.Speed += Data.Spped;
        owner.Critical += Data.Critical;
        owner.Hp += Data.MaxHp;
        owner.MaxHp += Data.MaxHp;
        owner.Dodge += Data.Dodge;
        owner.Armor += Data.Armor;
    }

    public void UnEquip()
    {
        owner = BattleManager.instance.CurCharacter as Player;
        owner.equipArmor = null;

        owner.AttackPoint -= Data.AttackPoint;
        owner.Speed -= Data.Spped;
        owner.Critical -= Data.Critical;
        owner.Hp -= Data.MaxHp;
        owner.MaxHp -= Data.MaxHp;
        owner.Dodge -= Data.Dodge;
        owner.Armor -= Data.Armor;
    }



}
