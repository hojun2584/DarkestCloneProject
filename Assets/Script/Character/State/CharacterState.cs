using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterState : BaseState
{
    protected GameObject gameObject;

    protected CharacterState(Character owner , Fsm machine)
        : base(machine)
    {
        this.owner = owner;
        if (!owner.TryGetComponent<Animator>(out aniCompo))
            Debug.Log("not find animator component");
        gameObject = owner.gameObject;
    }

    public override void EnterState()
    {

    }

    public override void ExitState()
    {
    }

    public override void UpdateState()
    {
    }
}
