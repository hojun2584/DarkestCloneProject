using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSet : DontDestroySingle<CharacterSet>
{



    public List<GameObject> playerArray = new List<GameObject>();
    public List<Image> images = new List<Image>();
    


    public GameObject archer;
    public GameObject warrior;
    public GameObject wizard;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void InsertItem(GameObject player)
    {
        playerArray.Add(player);
    }

}
