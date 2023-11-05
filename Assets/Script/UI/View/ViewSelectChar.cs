using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ViewSelectChar : MonoBehaviour
{
    [SerializeField]
    List<Image> icons;

    [SerializeField]
    CharacterSet setData;

    [SerializeField]
    Sprite noneImage;

    public void InitView()
    {
        List<GameObject> playerList = setData.playerArray;

        for (int i = 0; i < icons.Count; i++)
            icons[i].sprite = noneImage;

        for (int i = 0; i < playerList.Count && i < icons.Count ; i++)
            icons[i].sprite = playerList[i].GetComponent<Player>().icon;

    }


    public void Update()
    {

        InitView();

    }


}
