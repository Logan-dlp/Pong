using UnityEngine;

namespace Ball
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class BallBehaviour : MonoBehaviour
    {
        [SerializeField] private float _initialSpeed;
        [SerializeField] private float _maximalSpeed;
        [SerializeField] private float _speedIncrement;
        private float _speed;
        private Vector2 _direction;
        private Rigidbody2D _rigid;

        private void Awake()
        {
            _speed = _initialSpeed;
            _direction = new Vector2(Random.value, Random.value).normalized;
            _rigid = GetComponent<Rigidbody2D>();
            _rigid.velocity = _direction * _speed;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            _speed = Mathf.Min(_maximalSpeed, _speed+_speedIncrement);
            _direction = Vector2.Reflect(_direction, collision.transform.up);
            _rigid.velocity = _direction * _speed;
        }
    }
}