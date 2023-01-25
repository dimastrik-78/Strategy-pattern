using System;
using UnityEngine;

namespace Enemy
{
    public class Enemy3 : EnemyBase
    {
        [SerializeField] private KeyCode attack;
        [SerializeField] private Animator animator;
        
        public override void Update()
        {
            if (Input.GetKeyDown(attack))
            {
                animator.Play("Attack");
            }
        }
    }
}