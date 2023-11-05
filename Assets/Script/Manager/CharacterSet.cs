using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSet : DontDestroySingle<CharacterSet>
{

    public List<GameObject> playerArray = new List<GameObject>();

    public GameObject archer;
    public GameObject warrior;
    public GameObject wizard;

    [SerializeField]
    int maxPlayer = 3;


    public void InsertPlayer(GameObject player)
    {

        if(playerArray.Count < maxPlayer)
        {
            playerArray.Add(player);
        }
        else
        {
            MessageBox.ViewMessageBox("더 이상 플레이어가 들어가지 않습니다.");
        }

    
    }


    public void PopIPlayer(GameObject player)
    {
        if (playerArray.Count != 0)
        {
            playerArray.RemoveAt(playerArray.Count - 1);
        }
        else
        {
            MessageBox.ViewMessageBox("플레이어를 넣어 주세요.");
        }
    }

}
