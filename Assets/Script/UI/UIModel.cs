using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public enum TextName
{

    INVENTORY = 0,
    MAP = 1,
    STATUS = 2
}


public class UIModel : MonoBehaviour
{


    public TextName Toggle 
    {
        get
        {
            return toggle;
        }
        set
        {
            toggle = value;
            InitAll();
        }
    }
    TextName toggle = 0;



    public Dictionary<int, string> textDict = new Dictionary<int, string>();
    public List<InitViewAble> initAbleList = new List<InitViewAble>();

    
    private void Awake()
    {
        textDict.Add(0 , "Inventory");
        textDict.Add(1 , "Map");
        textDict.Add(2, "Status");
    }



    public void InitAll()
    {

        foreach (var initObject in initAbleList)
            initObject.InitView();
    }


    public void AddViewer(InitViewAble viewr)
    {
        initAbleList.Insert(initAbleList.Count,viewr);
    }


}
