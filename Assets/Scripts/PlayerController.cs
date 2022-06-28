using UnityEngine;

namespace Labirint 
{

    [RequireComponent(typeof(Rigidbody))]
    public class PlayerController : MonoBehaviour, IChangeSpeed
    {
        public float Speed
        {
            get => _speed;
            set => _speed = value;
        }

        [SerializeField] private float _speed;

        private Rigidbody _rb;

        private Vector3 _directional;

        private string _horizontal = "Horizontal";
        private string _vertical = "Vertical";

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void Start()
        {
        }

        private void Update()
        {
            _directional.x = Input.GetAxis(_horizontal);
            _directional.z = Input.GetAxis(_vertical);
        }

        private void FixedUpdate()
        {
            Vector3 dir = _rb.transform.TransformDirection(_directional * _speed);
            _rb.AddForce(dir, ForceMode.Force);
        }

        public void ChangeSpeed(float _speedBonus)
        {
            Speed += _speedBonus;
            Debug.Log(_speed);
        }

    }

}

