using System.Collections.Generic;
using Enemy.ProjectileLogic;
using UnityEngine;

namespace Enemy
{
    public class Enemy2 : EnemyBase
    {
        [SerializeField] private int countProjectile;
        [SerializeField] private GameObject prefabProjectile;
        [SerializeField] private Shoot shoot;
        
        private List<GameObject> _list = new();

        private void Start()
        {
            for (int i = 0; i < countProjectile; i++)
            {
                _list.Add(Instantiate(prefabProjectile, Vector3.zero, Quaternion.identity));
            }

            shoot.UpdateList(_list);
        }
        
        public override void Update() { }
    }
}