using Moving;

namespace Command
{
    public class Jump : ICommand
    {
        private readonly MovableActor _movableActor;

        public Jump(MovableActor movableActor)
        {
            _movableActor = movableActor;
        }
            
        public void Execute()
        {
            _movableActor.Jump();
        }
    }
}