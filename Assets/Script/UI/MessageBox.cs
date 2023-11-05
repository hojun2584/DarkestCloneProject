using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MessageBox : DontDestroySingle<MessageBox>
{

    public float fadeSpped = 1f;
    static Image background;
    static TextMeshProUGUI messageWriter;


    private new void Awake()
    {
        base.Awake();
        background = GetComponentInChildren<Image>();
        messageWriter = GetComponentInChildren<TextMeshProUGUI>();
        Color imageColor = background.color;

        imageColor.a = 0;
        background.color = imageColor;
        messageWriter.color = imageColor;

    }



    public static void ViewMessageBox(string message)
    {
        Color imageColor = background.color;
        imageColor.a = 1f;
        background.color = imageColor;
        messageWriter.text = message;

    }



    public void Update()
    {
        if (background.color.a >= 0)
        {

            // 255,255,255,255 setting 
            Color imageColor = background.color;
            imageColor.a -= fadeSpped * Time.deltaTime;
            background.color = imageColor;
            messageWriter.color = imageColor;
        }
    }


}
