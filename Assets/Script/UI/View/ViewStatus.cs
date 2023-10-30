using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ViewStatus : MonoBehaviour , InitViewAble
{
    // Start is called before the first frame update
    [SerializeField]
    Image face;

    [SerializeField]
    TextMeshProUGUI[] status;

    [SerializeField]
    Image armor;
    [SerializeField]
    Image weapon;
    [SerializeField]
    Image[] artifact = new Image[2];
    

    public CharacterData Data 
    { 
        set
        {
            
            data = value;
            InitView();
        }
    }
    CharacterData data;


    public void InitView()
    {
        if (data == null)
            return;

        var dataList = data.GetInitList;
        
        int i = 0;

        foreach ( var item in dataList ) 
        {
            status[i].text = item;
            i++;
        }
    }

    public void Update()
    {


        InitView();

    }

}