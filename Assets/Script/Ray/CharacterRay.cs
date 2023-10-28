using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CharacterRay : MonoBehaviour
{
    public RAYFLAGS flags;
    RaycastHit hitItem;
    [SerializeField]
    ViewStatus viewStat;

    public static ICharacter curCharacter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetCharacter();
    }
    public void SetCharacter()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                
                if (hit.collider.TryGetComponent<Player>(out Player targetP))
                {
                    // ���¸ӽ����� ó�� �� ��
                    //curCharacter = curChar;


                    if (!BattleManager.isBattleOn)
                    {
                        viewStat.Data = targetP.CharData;
                        BattleManager.CurCharacter = targetP;
                        Debug.Log("teget set");
                    }

                    BattleManager.Target = targetP;
                }
                if(hit.collider.TryGetComponent<Enemy>(out Enemy targetE))
                {
                    BattleManager.Target = targetE;
                }

            }
        }


    }


}
