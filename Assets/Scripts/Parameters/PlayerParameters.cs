using System;
using System.Collections.Generic;
using System.Linq;
using Items;
using UnityEditor;
using UnityEditor.Timeline.Actions;
using UnityEngine;

namespace Parameters
{
    public class PlayerParameters : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private float _speed;

        private Dictionary<string, IItem> _items;
        
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
        public Dictionary<string, IItem> Items => _items;

        public PlayerParameters()
        {
            _items = new Dictionary<string, IItem>();
            this.AddItem(new Backpack());
            this.AddItem(new Cockroach());
        }

        public void AddItem(IItem item)
        {
            _items.Add(item.Name, item);
        }

        public void RemoveItem(IItem item)
        {
            _items.Remove(item.Name);
        }
    }
}
