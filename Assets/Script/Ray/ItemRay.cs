using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRay : MonoBehaviour
{


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

        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                
            }
        }


        CharacterRay();

    }


    public void CharacterRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        
        if(Physics.Raycast(ray, out hit , Mathf.Infinity))
        {
            if(hit.collider.TryGetComponent<ICharacter>(out ICharacter curChar))
            {
                viewStat.Data = curChar.Data;
            }

        }

    }


}
