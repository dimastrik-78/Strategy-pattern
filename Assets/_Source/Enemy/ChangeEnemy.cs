using UnityEngine;
using UnityEngine.UI;

namespace Enemy
{
    public class ChangeEnemy : MonoBehaviour
    {
        [SerializeField] private GameObject enemy1;
        [SerializeField] private GameObject enemy2;
        [SerializeField] private GameObject enemy3;
        [SerializeField] private Button button1;
        [SerializeField] private Button button2;
        [SerializeField] private Button button3;
        
        void Start()
        {
            button1.onClick.AddListener(FirstVariantAttack);
            button2.onClick.AddListener(SecondVariantAttack);
            button3.onClick.AddListener(ThirdVariantAttack);
        }

        private void FirstVariantAttack()
        {
            enemy1.SetActive(true);
            enemy2.SetActive(false);
            enemy3.SetActive(false);
        }

        private void SecondVariantAttack()
        {
            enemy1.SetActive(false);
            enemy2.SetActive(true);
            enemy3.SetActive(false);
        }

        private void ThirdVariantAttack()
        {
            enemy1.SetActive(false);
            enemy2.SetActive(false);
            enemy3.SetActive(true);
        }
    }
}
