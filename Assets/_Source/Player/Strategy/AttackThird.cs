using UnityEngine;

namespace Player.Strategy
{
    public class AttackThird : IAttackStrategy
    {
        public void StartAnimation(Animator animation)
        {
            animation.Play("Attack3");
        }
    }
}
