using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Flags]
public enum RayFlags
{
    CHARACETER = 1,
    BUY,


}

public class ItemRay : MonoBehaviour
{

    public static RayFlags flags;
    



    RaycastHit hitItem;
    [SerializeField]
    ViewStatus viewStat;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CharacterRay();


    }


    public void CharacterRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.collider.TryGetComponent<ICharacter>(out ICharacter curChar))
                    viewStat.Data = curChar.CharData;
                
            }
        }
        

    }


}
