using UnityEngine;

namespace Player
{
    public class Listener : MonoBehaviour
    {
        
        
        private void Update()
        {
            if (Input.GetKeyDown(attack))
            {
                Debug.Log(Animator.StringToHash("Attack1"));
                // _character.PerformAttack();
            }
        }
    }
}