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


    public STATE state;


    private void Awake()
    {


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