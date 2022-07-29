using Attack;
using UnityEngine;

namespace Items
{
    public class Cockroach : IItem {

        private readonly IAttackBehavior _attackBehavior = new CockroachAttackBehavior();
        
        public string Name => "Таракан";

        public void Use()
        {
            _attackBehavior.Attack();
        }
    }
}