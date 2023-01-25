using System;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy.ProjectileLogic
{
    public class Shoot : MonoBehaviour
    {
        [SerializeField] private Transform spawnPoint;

        private List<GameObject> _listProjectiles = new();
        private int _count;

        private void CheckPool()
        {
            if (_count == _listProjectiles.Count)
            {
                _count = 0;
            }
        }

        private void EnableDisableObject()
        {
            // for (int i = 0; i < _listProjectiles.Count; i++)
            // {
            //     _listProjectiles[i].SetActive(false);
            // }
            // _listProjectiles[_count].SetActive(true);
            
            _listProjectiles[_count].SetActive(false);

            _count++;
            
            CheckPool();

            _listProjectiles[_count].SetActive(true);
        }

        private void TeleportBullet()
        {
            EnableDisableObject();
            _listProjectiles[_count].transform.position = spawnPoint.position;
        }
        
        private void OnEnable()
        {
            TeleportBullet();
            // Instantiate(prefabProjectile, spawnPoint.position, Quaternion.identity);
        }

        public void UpdateList(List<GameObject> list)
        {
            _listProjectiles = list;
        }
    }
}
