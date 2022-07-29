using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Items
{
    public class ItemButton : MonoBehaviour, IPointerDownHandler
    {
        public event Action OnButtonClicked;

        public void OnPointerDown(PointerEventData eventData)
        {
            OnButtonClicked?.Invoke();
        }
    }
}