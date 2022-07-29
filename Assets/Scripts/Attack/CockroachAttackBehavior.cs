using UnityEngine;

namespace Attack
{
    public class CockroachAttackBehavior : IAttackBehavior
    {
        public void Attack()
        {
            Debug.Log("Атака тараканом");
        }
    }
}