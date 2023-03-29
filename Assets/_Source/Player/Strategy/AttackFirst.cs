using UnityEngine;

namespace Player.Strategy
{
    public class AttackFirst : IAttackStrategy
    {
        public void StartAnimation(Animator animation)
        {
            animation.Play("Attack1");
        }
    }
}
