using UnityEngine;
using Parameters;

namespace Items
{
    public class Drop : MonoBehaviour
    {
        private IItem _item;

        public void SetDropItem(IItem item)
        {
            _item = item;
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.TryGetComponent(out PlayerParameters parameters))
            {
                bool resultOfAdding = parameters.PlayerItems.AddItem(_item);
                if (resultOfAdding == true)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}