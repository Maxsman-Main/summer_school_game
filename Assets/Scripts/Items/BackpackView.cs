using System.Collections;
using UnityEngine;

namespace Items
{
    public class BackpackView : MonoBehaviour
    {
        private float _timer;

        private void Start()
        {
            _timer = 0;
        }
        
        private void Update()
        {
            _timer += Time.deltaTime;
            if (_timer > 0.1f)
            {
                Destroy(gameObject);
            }
        }
    }
}