using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class IntroSceneBtn : MonoBehaviour
{

    public GameObject character;
    public CharacterSet setChar;


    public void InsertList()
    {
        setChar.InsertPlayer(character);
    }

    public void PopList()
    {
        setChar.PopIPlayer(character);
    }


    public void MainMove()
    {

        if (setChar.playerArray.Count <= 0)
            MessageBox.ViewMessageBox("�÷��̾ �߰� �� �ּ���.");
        else
            SceneController.LoadScene("Main");


        Debug.Log("click");
    }



}
