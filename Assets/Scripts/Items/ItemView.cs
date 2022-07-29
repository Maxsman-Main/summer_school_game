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
        public Action ButtonEvent
        {
            set => _button.OnButtonClicked += value;
        }
    }
}
