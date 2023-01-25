using UnityEngine;

namespace Enemy.ProjectileLogic
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rigidbody2D;
        [SerializeField] private float x;
        
        void OnEnable()
        {
            rigidbody2D.AddForce(new Vector2(x, 0), ForceMode2D.Impulse);
        }
    }
}
