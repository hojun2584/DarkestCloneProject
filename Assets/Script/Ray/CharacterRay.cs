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
                    // 상태머신으로 처리 할 것
                    //curCharacter = curChar;


                    if (!BattleManager.instance.isBattleOn)
                    {
                        viewStat.Data = targetP.CharData;
                        BattleManager.instance.CurCharacter.isMyTurn = false;
                        BattleManager.instance.CurCharacter = targetP;
                        BattleManager.instance.CurCharacter.isMyTurn = true;
                    }

                }
                if(hit.collider.TryGetComponent<Enemy>(out Enemy targetE))
                {
                    BattleManager.instance.Target = targetE;
                }

            }
        }


    }


}
