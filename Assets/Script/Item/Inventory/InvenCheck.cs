using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenCheck : MonoBehaviour
{
    [SerializeField]
    Inventory inven;

    public ItemData item;

    public void Temp()
    {
        inven.InsertItem( new Torch(item) );
    }


}
