using UnityEngine;

namespace Strategy
{
    public class Attack1 : IAttackStrategy
    {
        public void StartAnimation(Animator animation)
        {
            animation.Play("Attack1");
        }
    }
}
