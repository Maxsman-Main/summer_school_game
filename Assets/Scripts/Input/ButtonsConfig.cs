using System;
using Command;

namespace Input
{
    public class ButtonsConfig  
    {
        public ICommand ButtonA { get; set; }
        public ICommand ButtonD { get; set; }
        
        public ICommand ButtonSpace { get; set; }
    }
}