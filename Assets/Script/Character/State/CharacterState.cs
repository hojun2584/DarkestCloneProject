using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hojun;
using System.Buffers;

public class CharacterState : State
{
    protected GameObject gameObject;
    protected Character owner;
    protected Animator aniCompo;

    protected CharacterState(Character owner , IStateMachine machine)
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
