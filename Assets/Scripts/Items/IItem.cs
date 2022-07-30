using UnityEngine;

namespace Items
{
    public interface IItem
    {
        public string Name { get; }
        public void Use();

        public void SetSpawnPoint(Transform point);
    }
}