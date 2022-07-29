using System.Collections.Generic;
using UnityEngine;

namespace Items
{
    public class ItemsListVisualizer : MonoBehaviour
    {
        [SerializeField] private ItemView _itemView;
        [SerializeField] private GameObject _place;

        public void VisualizeList(Dictionary<string, IItem> items)
        {
            int counter = 0;
            foreach (var item in items)
            {
                var itemView =  Instantiate(_itemView, _place.transform, false);
                itemView.Name = item.Value.Name;
                itemView.ButtonEvent = item.Value.Use;
                
                var itemViewTransform = itemView.GetComponent<Transform>();
                //345 - 110 * counter use to make space between itemsView and shift of start itemView
                itemViewTransform.localPosition = new Vector3(0, 345 - 110 * counter, 0);
                
                counter += 1;
            }
        }
    }
}