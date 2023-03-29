using System;
using Player;
using UnityEngine;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private Animator animator;
        [SerializeField] private KeyCode attack;

        private Character _character;
        
        private void Awake()
        {
            _character = new Character();
        }
    }
}