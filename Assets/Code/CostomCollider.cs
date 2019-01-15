using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Game {
    public class CostomCollider : MonoBehaviour {
        public UnityEvent onTriggerEnter2D;
        private void OnTriggerEnter2D(Collider2D collision) {
            onTriggerEnter2D.Invoke();
            Debug.LogError(collision.gameObject.name);
        }
    }
}
