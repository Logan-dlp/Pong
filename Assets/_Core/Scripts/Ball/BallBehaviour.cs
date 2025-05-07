using UnityEngine;

namespace Pong.Ball
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class BallBehaviour : MonoBehaviour
    {
        [SerializeField] private int _initialSpeed;
        private BallSystem _ballSystem;
        private Rigidbody2D _rigidBody2D;

        private void Awake()
        {
            _ballSystem = new(_initialSpeed);
            _rigidBody2D = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            _rigidBody2D.velocity = _ballSystem.RandomLaunch();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            _rigidBody2D.velocity = _ballSystem.SurfaceBounce(collision.transform.up);
        }
    }
}