using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ViewStatus : MonoBehaviour , InitViewAble
{
    // Start is called before the first frame update

    Image face;

    [SerializeField]
    TextMeshProUGUI[] status;
    
    
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
        var dataList = data.GetInitList;

        
        for(int i = 0; i< status.Length; i++)
        {

            status[i].text = dataList[i];

        }
        
    }
}
