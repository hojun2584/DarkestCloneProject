using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipSlot : MonoBehaviour , IClickUseAble , IExplainAble
{

    Player player;
    Item item;
    Image view;

    [SerializeField]
    Inventory inven;

    [SerializeField]
    Sprite noneImage;


    public enum ViewFlag
    {
        ARMOR,
        WEAPON,
        ARTIFACT,
        ARTIFACT2,
    }

    [SerializeField]
    ViewFlag viewFlag = new ViewFlag();

    public string Comment 
    {
        get 
        {
            if (item == null)
                return null;

            return item.Data.Comment;
        }
    }

    private void Awake()
    {
        
        view = gameObject.GetComponent<Image>();

    }


    // Update is called once per frame
    void Update()
    {
        player = BattleManager.CurCharacter as Player;

        if (player == null)
            return;

        if (viewFlag == ViewFlag.ARMOR)
            item = player.equipArmor;

        if (viewFlag == ViewFlag.WEAPON)
            item = player.equipWeapon;


        if (item != null)
            view.sprite = item.itemData.SpriteImage;
        else
            view.sprite = noneImage;
            

    }

    public void OnClickUse()
    {
        Debug.Log("onclick");
        IEquipeAbleItem item = this.item as IEquipeAbleItem;

        if(item != null)
        {
            item.UnEquip();
            this.item.Data.Amount += 1;
            inven.InsertItem(this.item);
        }


    }

    public void ExplainView()
    {
        
    }
}
