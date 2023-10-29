using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertItemBtn : MonoBehaviour
{
    [SerializeField]
    Inventory inven;

    public ItemData item;
    public ArmorData armor;
    public WeaponData weapon;

    public void InsertItem()
    {
        
        inven.InsertItem(new HpPotion(item));

    }

    public void InsertEquip()
    {
        inven.InsertItem(new Armor(armor) );
        Debug.Log(armor.Armor);
    }

    public void InsertWeapon()
    {

    }


}
