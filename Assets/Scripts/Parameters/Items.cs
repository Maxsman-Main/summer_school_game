using System;
using System.Collections.Generic;
using Items;

namespace Parameters
{
    public class Items
    {
        private Dictionary<string, IItem> _value;

        public Dictionary<string, IItem> Value => _value;

        public event Action<Items> OnItemsDictionaryChanged;

        public Items()
        {
            _value = new Dictionary<string, IItem>();
            var backpack = new Backpack();
            var cockroach = new Cockroach();

            _value.Add(backpack.Name, backpack);
            _value.Add(cockroach.Name, cockroach);
        }

        public void RemoveItem(string key)
        {
            _value.Remove(key);
            OnItemsDictionaryChanged?.Invoke(this);
        }

        public void AddItem()
        {
            OnItemsDictionaryChanged?.Invoke(this);
        }
    }
}