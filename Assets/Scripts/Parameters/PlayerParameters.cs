using System;
using UnityEngine;

namespace Parameters
{
    public class PlayerParameters : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private int _speed;
        
        private IParameter _healthModel;
        private IParameter _speedModel;

        private void Start()
        {
            _health = new Health();
            _speed = new Speed();
        }
    }
}
