using System;

namespace Parameters
{
    public class Health : IParameter
    {
        private int _value;

        public event Action<int> OnValueChanged;

        public int Value
        {
            get => _value;
            set
            {
                _value = value <= 0 ? 0 : value;
                OnValueChanged?.Invoke(_value);
            }
        }
    }
}