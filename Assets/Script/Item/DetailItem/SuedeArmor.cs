using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuedeArmor : MonoBehaviour , IClickUseAble
{

    [SerializeField]
    ItemData suedeData;

    public Armor suede 
    { 
        get;
        set;
    }
    Armor armor;


    protected void Awake()
    {
        armor = new Armor(suedeData);    
    }

    public void OnClickUse()
    {
        
    }
}
