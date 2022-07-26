using UnityEngine;

namespace Command
{
    public class MovingRight : ICommand
    {
        public void Execute()
        {
            Debug.Log("MoveRight");       
        }
    }
}