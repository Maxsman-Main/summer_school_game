using System;
using UnityEngine;

namespace Items
{
    public class CockroachView : MonoBehaviour
    {
        [SerializeField] private float speed;
        
        private void FixedUpdate()
        {
            gameObject.transform.Translate(speed, 0, 0);
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            
        }
    }
}
