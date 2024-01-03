using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ViewStatus : MonoBehaviour , InitViewAble
{
    // Start is called before the first frame update
    [SerializeField]
    Image icon;

    [SerializeField]
    TextMeshProUGUI[] status;

    [SerializeField]
    Image armor;
    [SerializeField]
    Image weapon;
    [SerializeField]
    Image[] artifact = new Image[2];
    

    


    public void InitView()
    {
        Player player = BattleManager.instance.CurCharacter as Player;

        if (player == null)
            return;

        List<string> statusList = player.CharData.ViewtList;

        for (int i = 0; i< statusList.Count ; i++)
        {
            status[i].text = statusList[i];
        }

        icon.sprite = player.icon;
    }


    public void Start()
    {
        BattleManager.instance.setCurrentChar += InitView;
    }


}
