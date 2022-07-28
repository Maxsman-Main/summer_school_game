using UnityEngine;
using UnityEngine.UI;

namespace Items
{
    public class ItemView : MonoBehaviour
    {
        [SerializeField] private Text _name;

        public string Name
        {
            set => _name.text = value;
        }
    }
}
