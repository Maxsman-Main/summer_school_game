using Parameters;
using UnityEngine;

namespace Moving
{
    [RequireComponent(typeof(PlayerParameters))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class MovableActor : MonoBehaviour
    {
        [SerializeField] private GroundCheck _groundCheck;
        
        private Transform _transform;
        private PlayerParameters _parameters;
        private Rigidbody2D _rigidbody;

        private void Start()
        {
            _transform = gameObject.GetComponent<Transform>();
            _parameters = gameObject.GetComponent<PlayerParameters>();
            _rigidbody = gameObject.GetComponent<Rigidbody2D>();
        }

        public void MoveRight()
        {
            if (_transform.localScale.x == -1)
            {
                RotateX();
            }
            var moveVector = MakeMoveVector(_parameters.Speed);
            _transform.Translate(moveVector);
        }

        public void MoveLeft()
        {
            if (_transform.localScale.x == 1)
            {
                RotateX();
            }
            // minus used to invert moving direction
            var moveVector = MakeMoveVector(-_parameters.Speed);
            _transform.Translate(moveVector);
        }

        public void Jump()
        {
            if (!_groundCheck.IsGrounded)
            {
                return;
            }
            _rigidbody.AddForce(transform.up * _parameters.JumpForce, ForceMode2D.Impulse);
        }

        private Vector3 MakeMoveVector(float speed)
        {
            return new Vector3(speed, 0, 0);
        }

        private void RotateX()
        {
            var localScale = _transform.localScale;
            localScale = new Vector3
            (
                localScale.x * -1,
                localScale.y,
                localScale.z
            );
            _transform.localScale = localScale;
        }
    }
}