using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIText : MonoBehaviour , InitViewAble
{
    [SerializeField]
    UIModel model;
    TextMeshProUGUI textView;


    private void Awake()
    {
        textView = gameObject.GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        model.AddViewer(this);
    }

    public void Init()
    {

        

    }

    public void Update()
    {
        Init();
    }

}
