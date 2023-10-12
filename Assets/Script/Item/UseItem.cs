using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : Button
{

    ItemAdapter adapter;

    private void Start()
    {
        adapter = GetComponent<ItemAdapter>();
    }

    public override void OnClick()
    {
        if (adapter.Item == null)
            return;
     
        

        adapter.Item.Use();

        if (adapter.Item.Amount <= 0)
            adapter.Item = null;

        adapter.InitView();
    }
}
