using UnityEngine;

namespace Items
{
    public class Backpack : MonoBehaviour, IItem
    { 
        [SerializeField] private GameObject _spawnObject;

        private Transform _spawnPoint;
        
        public string Name => "Портфель";

        public void Use()
        {
            Instantiate(_spawnObject, _spawnPoint);
        }
        
        public void SetSpawnPoint(Transform point)
        {
            _spawnPoint = point;
        }
    }
}