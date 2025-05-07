using UnityEngine;

namespace Pong.Ball
{
    public class BallSystem
    {
        private float _speed;
        private Vector2 _direction;

        public BallSystem(int speed) { _speed = speed; }

        public Vector2 RandomLaunch()
        {
            _direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            return _direction * _speed;
        }

        public Vector2 SurfaceBounce(Vector2 surfaceBounceNormal) 
        {
            _speed++;
            _direction = Vector2.Reflect(_direction, surfaceBounceNormal);
            return _direction * _speed;
        }
    }
}
