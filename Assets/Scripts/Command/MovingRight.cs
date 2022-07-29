using Moving;
using UnityEngine;

namespace Command
{
    public class MovingRight : ICommand
    {
        private readonly MovableActor _movableActor;

        public MovingRight(MovableActor movableActor)
        {
            _movableActor = movableActor;
        }
        
        public void Execute()
        {
            _movableActor.MoveRight();
        }
    }
}