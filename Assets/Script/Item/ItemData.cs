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

    public string ItemName { get { return name; } }
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


}