using Attack;

namespace Items
{
    public class Backpack : IItem
    {
        private readonly IAttackBehavior _attackBehavior = new BackpackAttackBehavior();
        
        public string Name => "Портфель";

        public void Use()
        {
            _attackBehavior.Attack();
        }
    }
}