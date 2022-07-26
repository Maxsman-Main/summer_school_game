using System;
using Parameters;
using UnityEngine;

namespace Damage
{
    [RequireComponent(typeof(PlayerParameters))]
    public class DamagedActor : MonoBehaviour
    {
        private PlayerParameters _parameters;

        private void Start()
        {
            _parameters = gameObject.GetComponent<PlayerParameters>();
        }

        private void GetDamage(int value)
        {
            _parameters.Health -= value;
        }
    }
}
