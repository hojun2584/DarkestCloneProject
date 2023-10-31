using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneController : DontDestroySingle<SceneController>
{

    private new void Awake()
    {
        base.Awake();
    }

    // Update is called once per frame
    void Update()
    {
    
        if(Input.GetKey(KeyCode.B))
            SceneManager.LoadScene("Main");


        if (Input.GetKey(KeyCode.C))
            SceneManager.LoadScene("Intro");
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


}
