using System;
using System.Collections.Generic;
using Items;
using UnityEngine;

namespace Parameters
{
    public class PlayerParameters : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private float _speed;

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
        
        public PlayerParameters()
        {
            PlayerItems = new Items();
        }
    }
}
