using Items;
using Parameters;
using UnityEngine;

namespace GameController
{
    public class ActivePlayerChanger : MonoBehaviour
    {
        [SerializeField] private ItemsListVisualizer _itemsListVisualizer;
        [SerializeField] private GameObject _activePlayer;
        
        private void Start()
        {
            var parameters = _activePlayer.GetComponent<PlayerParameters>();
            _itemsListVisualizer.VisualizeList(parameters.PlayerItems);
            parameters.PlayerItems.OnItemsDictionaryChanged += _itemsListVisualizer.VisualizeList;
        }
    }
}