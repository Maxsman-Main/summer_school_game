using Parameters;
using UnityEngine;

namespace Moving
{
    [RequireComponent(typeof(PlayerParameters))]
    public class MovableActor : MonoBehaviour
    {
        private Transform _transform;
        private PlayerParameters _parameters;
        
        private void Start()
        {
            _transform = gameObject.GetComponent<Transform>();
            _parameters.GetComponent<PlayerParameters>();
        }

        public void MoveRight()
        {
            var moveVector = MakeMoveVector(_parameters.Speed);
            _transform.Translate(moveVector);
        }

        public void MoveLeft()
        {
            // minus used to invert moving direction
            var moveVector = MakeMoveVector(-_parameters.Speed);
            _transform.Translate(moveVector);
        }

        private Vector3 MakeMoveVector(float speed)
        {
            return new Vector3(speed, 0, 0);
        }
    }
}