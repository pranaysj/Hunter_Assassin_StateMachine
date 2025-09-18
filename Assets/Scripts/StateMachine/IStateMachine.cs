using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.StateMachine
{
    public interface IStateMachine
    {
        public void ChangeState(States newState);
    }
    public enum States
    {
        IDLE,
        ROTATING,
        SHOOTING,
        PATROLLING,
        CHASING
    }
}
