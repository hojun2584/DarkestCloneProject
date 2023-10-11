using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAdapter : MonoBehaviour
{

    
    public List<InitAble> Initcomponent = new List<InitAble>();

    public Item Item 
    {
        get{ return item;}
        set
        {
            item = value;
            foreach (var temp in Initcomponent)
                temp.Init();

           
        }
    }
    Item item;


}
