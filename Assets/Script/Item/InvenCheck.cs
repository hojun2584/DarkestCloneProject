using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvenCheck : MonoBehaviour
{
    [SerializeField]
    Inventory inven;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("insert");
            inven.InsertItem(new Torch());

        }
        if (Input.GetKey(KeyCode.B))
        {

            inven.InitViewItem();

        }
    }
}
