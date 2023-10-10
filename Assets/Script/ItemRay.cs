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
            // 카메라에서 화면의 마우스 위치로 Ray를 발사합니다.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Ray가 Collider와 충돌했는지 확인합니다.
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider.gameObject.TryGetComponent<Button>(out Button temp))
                    temp.OnClick();
                

            }
        }

    }
}
