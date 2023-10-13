using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ViewItem : MonoBehaviour, InitViewAble
{

    
    ItemAdapter adapter;

    [SerializeField]
    Image viewer;

    public Item ItemView
    {
        get
        {
            return adapter.Item;
        }
    }

    private void Awake()
    {
        adapter = GetComponent<ItemAdapter>();
    }

    private void Start()
    {
        adapter.Initcomponent.Insert(0, this);

    }

    public void Init()
    {
        if (ItemView == null)
        {
        }


    }

}
