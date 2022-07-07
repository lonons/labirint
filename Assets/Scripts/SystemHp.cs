
using UnityEngine;
namespace Labirint
{
    public delegate void HpDelegate();
    public delegate void DeathDelegate();

    public class SystemHp : MonoBehaviour, IChangeHp
    {
        private Observer _observer = new Observer();
        private UIHp _uiHp = new UIHp();
        private GameController _gameController;
        private DeathDelegate _deathDelegate;

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
                    _deathDelegate?.Invoke();
                }
                _observer.OnChanged();
            }
        }

        private void Awake()
        {
            GameObject go = GameObject.Find("GameControllerObject");
            _gameController = go.GetComponent<GameController>();
                
            _hp = maxHp;
        }

        private void Start()
        {
            _observer.AddFunc(_uiHp.UpdateUIHp);
            _deathDelegate += _gameController.GameOver;
        }

        public void ChangeHp(float hpbonus)
        {
            Hp += hpbonus;
            Debug.Log(Hp);
        }
    }
}

