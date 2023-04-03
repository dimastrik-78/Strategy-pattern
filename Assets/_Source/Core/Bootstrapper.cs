using System;
using Player;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private Listener listener;
        [SerializeField] private Animator animator;

        private Character _character;
        
        private void Awake()
        {
            _character = new Character();
            listener.OnButtonPress += _character.PerformAttack;
        }
    }
}