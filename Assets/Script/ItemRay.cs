using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRay : MonoBehaviour
{


    RaycastHit hitItem;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            // ī�޶󿡼� ȭ���� ���콺 ��ġ�� Ray�� �߻��մϴ�.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Ray�� Collider�� �浹�ߴ��� Ȯ���մϴ�.
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider.gameObject.TryGetComponent<Button>(out Button temp))
                    temp.OnClick();
                

            }
        }

    }
}
