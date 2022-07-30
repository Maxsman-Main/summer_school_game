using UnityEngine;

namespace Items
{
    public class Cockroach : MonoBehaviour, IItem
    {
        [SerializeField] private GameObject _spawnObject;

        private Transform _spawnPoint;
        
        public string Name => "Таракан";

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