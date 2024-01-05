using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.XR;


namespace Hojun
{

    public interface IStateMachine
    {
        public Object GetOwner { get; }
        public void ChangeState(State state);
        public void UpdateState();
    }


    public abstract class StateMachine<T> : IStateMachine where T : class
    {
        public State curState = null;
        public T owner;

        protected StateMachine(T owner)
        {
            this.owner = owner;

        }

        public Object GetOwner
        {
            get
            {
                return (System.Object)owner;
            }
        }


        public void ChangeState(State nextState)
        {

            if (curState == nextState)
                return;

            if (curState != null)
                curState.ExitState();

            curState = nextState;
            curState.EnterState();

        }

        public virtual void UpdateState()
        {
            if (curState == null)
                return;
            curState.UpdateState();
        }


    }
}