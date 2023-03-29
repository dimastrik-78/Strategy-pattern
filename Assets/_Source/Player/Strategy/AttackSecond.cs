using UnityEngine;

namespace Player.Strategy
{
    public class AttackSecond : IAttackStrategy
    {
        public void StartAnimation(Animator animation)
        {
            animation.Play("Attack2");
        }
    }
}
