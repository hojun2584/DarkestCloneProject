using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAdapter : MonoBehaviour
{

    
    public List<InitViewAble> Initcomponent = new List<InitViewAble>();

    public Item Item 
    {
        get
        {
            return item;
        }
        set
        {
            item = value;
            foreach (var initItem in Initcomponent)
                initItem.Init();
        }
    }
    Item item;


    public void InitView()
    { 
            

        foreach (var initItem in Initcomponent)
            initItem.Init();

    }


}
