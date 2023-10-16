using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenCheck : MonoBehaviour
{
    [SerializeField]
    Inventory inven;

    
    public ItemData item;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(item.ItemName == null);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("insert");
            inven.InsertItem(new Torch(item) );

        }
        if (Input.GetKey(KeyCode.B))
        {

            inven.InitViewItem();

        }
    }



    public void Temp()
    {
        
        if (inven == null)
            Debug.Log("check");


        inven.InsertItem(new Torch(item));


    }


}
