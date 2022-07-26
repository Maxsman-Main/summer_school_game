using Command;
using Moving;
using UnityEngine;

namespace Input
{
    public class InputHandler : MonoBehaviour
    {
        [SerializeField] private MovableActor _movableActor;
        
        private ButtonsConfig _buttons;
        
        private void Start()
        {
            _buttons = new ButtonsConfig();
            _buttons.ButtonA = new MovingLeft(_movableActor);
            _buttons.ButtonD = new MovingRight(_movableActor);
        }

        private void FixedUpdate()
        {
            if (UnityEngine.Input.GetKey(KeyCode.A))
            {
                _buttons.ButtonA.Execute();
            }

            if (UnityEngine.Input.GetKey(KeyCode.D))
            {
                _buttons.ButtonD.Execute();
            }
        }
    }
}
