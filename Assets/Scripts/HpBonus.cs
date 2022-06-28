using UnityEngine;
using static UnityEngine.Debug;

namespace Labirint
{
    public class HpBonus : MonoBehaviour
    {
        [SerializeField] private float _hpBonus;
        private void OnTriggerEnter(Collider other)
        {

            if (other.CompareTag("Player"))
            { 
                if (other.TryGetComponent(out IChangeHp _changeHP))
                {
                    _changeHP.ChangeHp(_hpBonus);
                }
            }
        }
    }

}
