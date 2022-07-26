using Moving;
using UnityEngine;

namespace Command
{
    public class MovingLeft : ICommand
    {
        private readonly MovableActor _movableActor;

        public MovingLeft(MovableActor movableActor)
        {
            _movableActor = movableActor;
        }
        
        public void Execute()
        {
            _movableActor.MoveLeft();
        }
    }
}