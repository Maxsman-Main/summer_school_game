using Moving;
using UnityEngine;

namespace Command
{
    public class MovingRight : ICommand
    {
        private MovableActor _movableActor;

        public MovingRight(MovableActor movableActor)
        {
            _movableActor = movableActor;
        }
        
        public void Execute()
        {
            Debug.Log("MoveRight");       
        }
    }
}