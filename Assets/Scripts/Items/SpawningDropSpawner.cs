using System.Collections.Generic;
using UnityEngine;

namespace Items
{
    public class SpawningDropSpawner : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _items;
        [SerializeField] private Transform _itemUsePoint;
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] private Drop _drop;
        
        private void Start()
        {
            foreach (var item in _items)
            {
                item.GetComponent<IItem>().SetSpawnPoint(_itemUsePoint);
            }
            SpawnDrop(_items[1].GetComponent<IItem>(), _spawnPoint);
            gameObject.transform.Translate(new Vector3(-5, 0, 0));
            SpawnDrop(_items[0].GetComponent<IItem>(), _spawnPoint);
        }

        private void SpawnDrop(IItem item, Transform position)
        {
            var drop = Instantiate(_drop, position.localPosition, Quaternion.identity);
            drop.SetDropItem(item);
        }
    }
}