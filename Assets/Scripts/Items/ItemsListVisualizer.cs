using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Items
{
    public class ItemsListVisualizer : MonoBehaviour
    {
        [SerializeField] private ItemView _itemView;
        [SerializeField] private GameObject _place;

        public void VisualizeList(Dictionary<string, IItem> items)
        {
            foreach (var item in items)
            { 
                var itemView =  Instantiate(_itemView, _place.transform, false);
                itemView.Name = item.Value.Name;
            }
        }
    }
}