using UnityEngine;

namespace Labirint
{
    public class SpeedBonus : MonoBehaviour, IChangeSpeed
    {
        [SerializeField] private float _speedBonus;
        private void OnTriggerEnter(Collider other)
        {

            if (other.CompareTag("Player"))
            {
                var playerController = other.GetComponent<PlayerController>();
                playerController.Speed = ChangeSpeed(playerController.Speed);
                Debug.Log(playerController.Speed);
            }
        }

        public float ChangeSpeed(float speed)
        {
            return speed += _speedBonus;
        }
    }

}
