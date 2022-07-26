using Command;
using Moving;
using UnityEngine;

namespace Input
{
    public class InputHandler : MonoBehaviour
    {
        //todo new class, which bind buttons for buttonsConfig and link its with InputHandler(I guess good idea use pattern Mediator?)
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
