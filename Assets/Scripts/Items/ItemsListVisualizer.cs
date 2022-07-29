using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

namespace Items
{
    public class ItemsListVisualizer : MonoBehaviour
    {
        [SerializeField] private ItemView _itemView;
        [SerializeField] private GameObject _place;

        private List<ItemView> _itemsViews = new List<ItemView>();
        
        public void VisualizeList(Parameters.Items items)
        {
            int counter = 0;
            foreach (var item in items.Value)
            {
                var itemView =  Instantiate(_itemView, _place.transform, false);
                itemView.Name = item.Value.Name;
                _itemsViews.Add(itemView);
                
                itemView.SubscribeOnButtonClick(item.Value.Use);
                itemView.SubscribeOnButtonClick(() =>
                {
                    foreach (var _ in _itemsViews)
                    {
                        _.Die();
                    }

                    _itemsViews = new List<ItemView>();
                });
                itemView.SubscribeOnButtonClick(() => { items.RemoveItem(item.Value.Name);});

                var itemViewTransform = itemView.GetComponent<Transform>();
                //345 - 110 * counter use to make space between itemsView and shift of start itemView
                itemViewTransform.localPosition = new Vector3(0, 345 - 110 * counter, 0);

                counter += 1;
            }
        }
    }
}