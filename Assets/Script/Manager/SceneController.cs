using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneController : DontDestroySingle<SceneController>
{

    private new void Awake()
    {
        base.Awake();

        Debug.Log("scene awke call");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene("Intro");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            SceneManager.LoadScene("Main");
        }

    }

    //button click component [SerializeField] use
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


}
