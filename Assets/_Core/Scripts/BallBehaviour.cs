using UnityEngine;

namespace Ball
{
    public class BallBehaviour : MonoBehaviour
    {
        [SerializeField] private float _speed;
        private Vector2 _direction;

        private void Awake()
        {
            _direction = new Vector2(Random.value, Random.value).normalized;
        }
        private void Update()
        {
            gameObject.transform.Translate(_speed * Time.deltaTime * _direction);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            _direction = Vector2.Reflect(_direction, collision.transform.up);
            _speed += 0.1f;
        }
    }
}