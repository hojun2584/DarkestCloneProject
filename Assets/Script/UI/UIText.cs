using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UIText : MonoBehaviour , InitViewAble
{
    [SerializeField]
    protected UIModel model;
    protected TextMeshProUGUI textView;

    public TextName ModelName 
    {
        get => modelName;
        set
        {
            modelName = value;
        }
    }
    TextName modelName;
    

    protected void Awake()
    {
        if (model == null)
            model = GameObject.Find("UiModel").gameObject.GetComponent<UIModel>();

    }

    protected void Start()
    {
        TryGetComponent<TextMeshProUGUI>(out textView);
        model.AddViewer(this);
    }

    public virtual void Init() 
    {
        modelName = model.Toggle;
        textView.text = model.textDict[(int)ModelName];
        return;
    }

}
