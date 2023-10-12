using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Button : MonoBehaviour
{
    


    public IButtonStartegy ButtonStartegy 
    {
        get
        {
            return buttonStartegy;
        }
        set
        {
            buttonStartegy = value;
        }
    }
    IButtonStartegy buttonStartegy;

    [SerializeField]
    Inventory inven;



    // Start is called before the first frame update
    void Start()
    {
        buttonStartegy = new InsertButton(new Torch() , inven);
    }

    public virtual void OnClick()
    {
        ButtonStartegy.OnClick();
    }

}
