using UnityEngine;
using static UnityEngine.Debug;

namespace Labirint
{
    public class HpBonus : MonoBehaviour, IChangeHp
    {
        [SerializeField] private float _hpBonus;
        private void OnTriggerEnter(Collider other)
        {

            if (other.CompareTag("Player"))
            {
                var playerController = other.GetComponent<SystemHp>();
                playerController.Hp = ChangeHp(playerController.Hp);
                Log(playerController.Hp);
            }
        }

        public float ChangeHp(float hp)
        {
            return hp += _hpBonus;
        }
    }

}
