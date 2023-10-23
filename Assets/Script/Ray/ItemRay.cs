using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[Flags]
public enum RAYFLAGS
{
    STATUS = 1 << 8,
    INVENTORY = 1 << 9
}

public class ItemRay : MonoBehaviour
{
    [SerializeField]
    GraphicRaycaster graphicRay;
    PointerEventData pEventData = new PointerEventData(null);
    List<RaycastResult> rayResult = new List<RaycastResult>();

    RAYFLAGS mask;

    public RAYFLAGS InvenMask;
    public RAYFLAGS statusMask;


    // Start is called before the first frame update
    void Start()
    {
        if (graphicRay == null)
            graphicRay = GameObject.Find("DungeonUI").GetComponent<GraphicRaycaster>();

        InvenMask |= RAYFLAGS.INVENTORY;
        statusMask |= RAYFLAGS.STATUS;

    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SearchItemToMask(InvenMask);
            SearchItemToMask(statusMask);
        }
    }

    public void SearchItemToMask(RAYFLAGS mask)
    {


        PointerEventData pointerData = new PointerEventData(EventSystem.current);
        pointerData.position = Input.mousePosition;

        List<RaycastResult> raycastResults = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerData, raycastResults);


        foreach (RaycastResult result in raycastResults)
        {

            if((RAYFLAGS)(1 << result.gameObject.layer) == mask)
            {
                if (result.gameObject.TryGetComponent<ItemSlot> (out ItemSlot slot))
                {
                    if (slot.HaveItem != null)
                        slot.OnClickUse();

                }
                    
            }




        }

    }



    public void GetItem()
    {
        rayResult.Clear();
        pEventData.position = Input.mousePosition;
        graphicRay.Raycast(pEventData, rayResult);



    }

    


}
