using System;
using Command;
using UnityEngine;

namespace Input
{
    public class InputHandler : MonoBehaviour
    {
        private ButtonsConfig _buttons;
        
        private void Start()
        {
            _buttons = new ButtonsConfig();
            _buttons.ButtonA = new MovingLeft();
            _buttons.ButtonD = new MovingRight();
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
