using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInsertBtn : MonoBehaviour
{

    public GameObject character;

    public CharacterSet setChar;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    public void Onclick()
    {

        Debug.Log("insertBtn");
        setChar.InsertItem(character);

    }




}
