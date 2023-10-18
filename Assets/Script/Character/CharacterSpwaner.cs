using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpwaner : MonoBehaviour
{

    [SerializeField]
    Transform[] pos = new Transform[4];

    public GameObject archer;


    // Start is called before the first frame update
    void Start()
    {


        Instantiate(archer, pos[0]);
        Instantiate(archer, pos[1]);
        Instantiate(archer, pos[2]);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
