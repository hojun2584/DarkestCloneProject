using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemEnum
{
    POTION,
    ARMOR,
    WEAPON
}


public class InsertItemBtn : MonoBehaviour
{
    [SerializeField]
    Inventory inven;

    public ItemData potion;
    public ArmorData armor;
    public WeaponData weapon;

    Image viewer;

    public ItemEnum itemSelect;

    [SerializeField]
    ItemData hpPotion;

    Dictionary<ItemEnum , Item> itemDict = new Dictionary<ItemEnum , Item>();


    ItemEnum GetRandomItem()
    {
        Array values = Enum.GetValues(typeof(ItemEnum));
        return (ItemEnum)values.GetValue(UnityEngine.Random.Range(0, values.Length));
    }

    private void Awake()
    {
        

        viewer = GetComponent<Image>();

    }

    public void Start()
    {
        itemSelect = GetRandomItem();

        switch (itemSelect)
        {
            case ItemEnum.POTION:
                viewer.sprite = potion.SpriteImage;
                break;
            case ItemEnum.ARMOR:
                viewer.sprite = armor.SpriteImage;
                break;
            case ItemEnum.WEAPON:
                viewer.sprite = weapon.SpriteImage;
                break;
        }

        Debug.Log(itemSelect);

    }


    public void InsertItem()
    {
        

        switch (itemSelect)
        {
            case ItemEnum.POTION:
                inven.InsertItem(new HpPotion(potion));
                break;
            case ItemEnum.ARMOR:
                inven.InsertItem(new Armor(armor,inven));
                break;
            case ItemEnum.WEAPON:
                inven.InsertItem(new Weapon(weapon,inven));
                break;
        }



    }




}
