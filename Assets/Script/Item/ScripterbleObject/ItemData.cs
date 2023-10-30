using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;







[CreateAssetMenu(fileName ="ItemData" , menuName ="ScriptableObject/ItemData") ]
public class ItemData : ScriptableObject
{

    public int Amount 
    {
        get
        {
            return amount;
        }
        set
        {
            amount = value;
        }
    }
    [SerializeField]
    int amount;

    public int MaxAmount
    {
        get
        {
            return maxAmount;
        }
        set
        {
            maxAmount = value;
        }
    }
    [SerializeField]
    int maxAmount;
    
    public int Cost { get { return cost; } set { cost = value; } }
    [SerializeField]
    int cost;

    public string ItemName 
    {
        get 
        { 
            return itemName;
        } 
        set 
        { 
            itemName = value;
        }
    }
    [SerializeField]
    string itemName;


    public Sprite SpriteImage 
    {
        get => spriteImage;
        set
        {
            spriteImage = value;
        }
    }
    [SerializeField]
    Sprite spriteImage;


    public ItemData CloneObj 
    {
        get
        {
            return Instantiate(this);
        }
    }

    public virtual string Comment 
    {
        get
        {
            return comment;
        }
    }
    [SerializeField]string comment;
    


}