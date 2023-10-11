using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour, IButtonStartegy
{

    ItemAdapter adapter;

    private void Start()
    {
        adapter = GetComponent<ItemAdapter>();
    }

    public void OnClick()
    {
        adapter.Item.Use();
    }
}
