
using UnityEngine;
namespace Labirint
{
    public class SystemHp : MonoBehaviour
    {
        [SerializeField] private float maxHp = 100;
        private float _hp;
        public float MaxHp
        {
            get => maxHp;
            set => maxHp = value;
        }
        public float Hp
        {
            get => _hp;
            set 
            {
                _hp = value;
                if (_hp>= maxHp)
                {
                    _hp = maxHp;
                }
                if (_hp <= 0)
                {
                    Death();
                }
            }
        }

        private void Awake()
        {
            _hp = maxHp;
        }

        private void Death()
        {
            Destroy(gameObject);
        }
    }
}

