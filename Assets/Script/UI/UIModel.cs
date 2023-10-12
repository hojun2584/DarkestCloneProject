using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public enum ToggleButton
{

    INVENTORY = 0,
    MAP = 1

}


public class UIModel : MonoBehaviour
{


    public ToggleButton toggle = new ToggleButton();
    public Dictionary<int, string> textDict = new Dictionary<int, string>();
    List<InitViewAble> initAbleList = new List<InitViewAble>();


    
    private void Awake()
    {
        textDict.Add(0 , "Inventory");
        textDict.Add(1 , "Map");
    }



    public void InitAll()
    {

        foreach (var initObject in initAbleList)
            initObject.Init();
    }

    public bool InitObj(InitViewAble initobject)
    {
        var obj = initAbleList.Find(x => x == initobject);

        if (obj == null)
            return false;

        obj.Init();
        return true;

    }


    public void AddViewer(InitViewAble viewr)
    {
        initAbleList.Insert(initAbleList.Count,viewr);
    }


}
