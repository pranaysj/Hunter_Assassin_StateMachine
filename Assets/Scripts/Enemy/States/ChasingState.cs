using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.StateMachine;

namespace StatePattern.Enemy
{
    public class ChasingState : IState
    {
        public EnemyController Owner { get; set; }
        public IStateMachine stateMachine;

        public ChasingState(IStateMachine stateMachine)
        {
            this.stateMachine = stateMachine;
        }

        public void OnStateEnter()
        {
            throw new NotImplementedException();
        }

        public void OnStateExit()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
