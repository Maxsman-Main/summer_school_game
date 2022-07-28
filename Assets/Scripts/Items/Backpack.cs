using Attack;

namespace Items
{
    public class Backpack : IItem
    {
        private string _name = "Портфель";
        private IAttackBehavior _attackBehavior;
        
        public string Name
        {
            get => _name;
        }

        public void Use()
        {
            _attackBehavior.Attack();
        }
    }
}