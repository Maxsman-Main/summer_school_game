using UnityEngine;

namespace Attack
{
    public class BackpackAttackBehavior : IAttackBehavior
    {
        public void Attack()
        {
            Debug.Log("Атака портфелем");
        }
    }
}