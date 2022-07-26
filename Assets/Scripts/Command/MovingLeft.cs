using UnityEngine;

namespace Command
{
    public class MovingLeft : ICommand
    {
        public void Execute()
        {
            Debug.Log("MoveLeft");       
        }
    }
}