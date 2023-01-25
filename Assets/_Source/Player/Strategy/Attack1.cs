using UnityEngine;

namespace Player.Strategy
{
    public class Attack1 : IAttackStrategy
    {
        public void StartAnimation(Animator animation)
        {
            animation.Play("Attack1");
        }
    }
}
