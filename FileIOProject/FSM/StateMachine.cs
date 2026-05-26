using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOProject.FSM
{
    public enum State
    {
        idle, 
        sitting,
        combat,
        sleeping,
        dead
    }
    public class StateMachine
    {
        public State CurrentState { get; private set; }
        public StateMachine(State CurrentState)
        {
            this.CurrentState = CurrentState;
        }
        public virtual void transition(State toState)
        {
            CurrentState = toState;
            if(CurrentState == State.dead)
            {
                //dead code here
            }
        }
    }
}
