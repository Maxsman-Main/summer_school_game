using System;
using UnityEngine;
using UnityEngine.UI;

namespace Items
{
    public class ItemView : MonoBehaviour
    {
        [SerializeField] private Text _name;
        [SerializeField] private ItemButton _button;

        public string Name
        {
            set => _name.text = value;
        }

        public void SubscribeOnButtonClick(Action buttonEvent)
        {
            _button.OnButtonClicked += buttonEvent;
        }

        public void Die()
        {
            Destroy(gameObject);
        }
    }
}
