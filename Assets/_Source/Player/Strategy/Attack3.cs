using UnityEngine;

namespace Player.Strategy
{
    public class Attack3 : IAttackStrategy
    {
        public void StartAnimation(Animator animation)
        {
            animation.Play("Attack3");
        }
    }
}
