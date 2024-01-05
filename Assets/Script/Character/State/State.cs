using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Hojun;

namespace Hojun
{

    public abstract class State
    {
        protected IStateMachine machine = null;

        protected State(IStateMachine machine)
        {
            this.machine = machine;
        }
        public virtual void SetStateMachine( IStateMachine machine )
        {
            this.machine = machine;
        }
        public abstract void EnterState();
        public abstract void UpdateState();
        public abstract void ExitState();

    }
}