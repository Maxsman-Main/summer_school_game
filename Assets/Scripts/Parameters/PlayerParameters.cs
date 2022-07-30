using System;
using UnityEngine;

namespace Parameters
{
    public class PlayerParameters : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private float _speed;
        [SerializeField] private float _jumpForce;

        public Items PlayerItems { get; private set; }
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

        public float Speed => _speed;
        public float JumpForce => _jumpForce;
        
        public PlayerParameters()
        {
            PlayerItems = new Items();
        }
    }
}
