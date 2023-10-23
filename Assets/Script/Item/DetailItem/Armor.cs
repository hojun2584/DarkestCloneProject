using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Item, IEquipeAbleItem
{

    public Armor(ItemData data) : base(data)
    {

    }

    [SerializeField]
    ArmorData armorInfo;
    public ArmorData ArmorInfo
    {
        get
        {
            return armorInfo;
        }
    }

    public override void Use(ICharacter user , ICharacter target = null)
    {
        Equip(user);
    }

    public virtual void Equip(ICharacter equipTarget)
    {
        equipTarget.CharData.AddArmor(this);
    }

}
