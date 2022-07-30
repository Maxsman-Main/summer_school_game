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
            ClearItemsView();
            foreach (var item in items.Value)
            {
                var itemView =  Instantiate(_itemView, _place.transform, false);
                itemView.Name = item.Value.Name;
                _itemsViews.Add(itemView);
                
                itemView.SubscribeOnButtonClick(item.Value.Use);
                itemView.SubscribeOnButtonClick(ClearItemsView);
                itemView.SubscribeOnButtonClick(() =>  items.RemoveItem(item.Value.Name));
            }
        }

        private void ClearItemsView()
        {
            foreach (var itemView in _itemsViews)
            {
                itemView.Die();
            }

            _itemsViews = new List<ItemView>();
        }
    }
}