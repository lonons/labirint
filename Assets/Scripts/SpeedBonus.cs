using UnityEngine;

namespace Labirint
{
    public class SpeedBonus : MonoBehaviour
    {
        [SerializeField] private float _speedBonus;
        private void OnTriggerEnter(Collider other)
        {

            if (other.CompareTag("Player"))
            {
                if (other.TryGetComponent(out IChangeSpeed _changeSpeed))
                {
                    _changeSpeed.ChangeSpeed(_speedBonus);
                }
            }
        }
    }

}
