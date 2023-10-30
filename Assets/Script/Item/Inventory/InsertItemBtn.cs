using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    [SerializeField]
    GameObject shopObject;


    public ItemData potion;
    public ArmorData armor;
    public WeaponData weapon;
    public TextMeshProUGUI itemName;

    Image viewer;

    public ItemEnum itemSelect;


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



    public void OnEnable()
    {
        itemSelect = GetRandomItem();

        Debug.Log("enable");


        switch (itemSelect)
        {
            case ItemEnum.POTION:
                viewer.sprite = potion.SpriteImage;
                itemName.text = potion.ItemName;
                break;
            case ItemEnum.ARMOR:
                viewer.sprite = armor.SpriteImage;
                itemName.text = armor.ItemName;
                break;
            case ItemEnum.WEAPON:
                viewer.sprite = weapon.SpriteImage;
                itemName.text = weapon.ItemName;
                break;
        }


    }


    public void InsertItem()
    {
        Debug.Log("insertItem item select" + itemSelect);

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

        shopObject.SetActive(false);
        BattleManager.isBattleOn = false;
    }




}
