using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMover : MonoBehaviour
{
    [SerializeField]
    float speed = 3.0f;



    [SerializeField]
    float blinkPos = -16400;
    [SerializeField]
    float spawnPos = 16400;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(!BattleManager.instance.isBattleOn)
        {
           if (Input.GetKey(KeyCode.D))
                gameObject.transform.Translate(-transform.right * speed);

        }


        if (gameObject.transform.position.x <= blinkPos)
            gameObject.transform.position = new Vector3(spawnPos,transform.position.y,transform.position.z);



    }
}
