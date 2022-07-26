using UnityEngine;

namespace Moving
{
    public class MovableActor : MonoBehaviour
    {
        [SerializeField] private float _speed;
        
        private Transform _transform;

        private void Start()
        {
            _transform = gameObject.GetComponent<Transform>();
        }

        public void MoveRight()
        {
            var moveVector = MakeMoveVector(_speed);
        }

        public void MoveLeft()
        {
            // minus used to invert moving direction
            var moveVector = MakeMoveVector(-_speed);
        }

        private Vector3 MakeMoveVector(float speed)
        {
            return new Vector3(speed, 0, 0);
        }
    }
}