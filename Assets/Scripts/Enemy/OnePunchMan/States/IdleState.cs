using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace StatePattern.Enemy
{
    /// <summary>
    /// The Idle state for the OnePunchMan enemy.
    /// </summary>
    /// <remarks>
    /// This state represents the behavior of the OnePunchMan when it is idle.
    /// </remarks>
    public class IdleState : IState
    {
        public OnePunchManController Owner { get ; set ; }
        private OnePunchManStateMachine stateMachine;   
        public float timer;

        public IdleState(OnePunchManStateMachine stateMachine)
        {
            this.stateMachine = stateMachine;
        }

        public void OnStateEnter() => ResetTimer();

        public void Update()
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                stateMachine.ChangeState(OnePunchManStates.ROTATING);
            }
        }
        public void OnStateExit() => timer = Owner.Data.IdleTime;

        private void ResetTimer() => timer = 0;
    }
}

