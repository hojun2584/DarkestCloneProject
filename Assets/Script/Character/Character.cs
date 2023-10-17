using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum STATE
{

    IDLE = 0,
    RUN,
    ATTACK,
    CRITICAL,
    HIT,
    DIE,

}

public class Character : MonoBehaviour, ICharacter
{


    public CharacterData CharStatus
    {
        get;
        set;
    }
    CharacterData charStatus;

    public STATE state;


    protected Dictionary<STATE, ChracterState> stateDict = new Dictionary<STATE, ChracterState>();

    private void Awake()
    {


    }

    public void SetState()
    {
        if (0 != Input.GetAxis("horizontal") || 0 != Input.GetAxis("vertical") )
            state = STATE.RUN;

        if (Input.GetKey(KeyCode.Mouse0))
            state = STATE.ATTACK; 


    }


    public virtual void StateRun()
    {

        switch (state)
        {
            case STATE.DIE:
                break;
            case STATE.RUN:
                break;
            case STATE.HIT:
                break;
            case STATE.IDLE:
                break;
            case STATE.CRITICAL:
                break;
            case STATE.ATTACK:
                break;
        }

    }
}