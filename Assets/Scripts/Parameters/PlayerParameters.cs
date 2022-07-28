using System;
using UnityEngine;

namespace Parameters
{
    public class PlayerParameters : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private int _speed;

        public event Action<int> OnHealthChanged;

        public int Health
        {
            get => _health;
            set
            {
                _health = value < 0 ? 0 : value;
                OnHealthChanged?.Invoke(value);
            }
        }

        public int Speed => _speed;
    }
}
