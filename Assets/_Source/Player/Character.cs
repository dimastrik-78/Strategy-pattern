using System;
using Player.Strategy;
using UnityEngine;

namespace Player
{
    public class Character
    {
        private AttackFirst _attackFirst;
        private AttackSecond _attackSecond;
        private AttackThird _attackThird;
        private int _variantAttack;

        private void Awake()
        {
            _attackFirst = new AttackFirst();
            _attackSecond = new AttackSecond();
            _attackThird = new AttackThird();
        }

        public void SetStrategy(int variant) => _variantAttack = variant;

        public void PerformAttack()
        {
            if (_variantAttack == 1)
            { 
                _attackFirst.StartAnimation(animator);
            }
            else if (_variantAttack == 2)
            {
                _attackSecond.StartAnimation(animator);
            }
            else if (_variantAttack == 3)
            {
                _attackThird.StartAnimation(animator);
            }
        }
    }
}
