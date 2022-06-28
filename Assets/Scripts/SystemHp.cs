
using UnityEngine;
namespace Labirint
{
    public delegate void HpDelegate();

    public class SystemHp : MonoBehaviour, IChangeHp
    {
        private Observer _observer = new Observer();
        private UIHp _uiHp = new UIHp();

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
                _observer.OnChanged();
            }
        }

        private void Awake()
        {
            _hp = maxHp;
        }

        private void Start()
        {
            _observer.AddFunc(_uiHp.UpdateUIHp);   
        }

        private void Death()
        {
            Destroy(gameObject);
        }

        public void ChangeHp(float hpbonus)
        {
            Hp += hpbonus;
            Debug.Log(Hp);
        }
    }
}

