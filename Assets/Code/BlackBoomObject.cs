using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game {
    public class BlackBoomObject : MonoBehaviour {
        [SerializeField]
        private CostomCollider  costomCollider;
        [SerializeField]
        private Rigidbody2D rigidbody;

        private void Awake() {
            //rigidbody.velocity = new Vector2(2, 5);
        }

        // Use this for initialization
        void Start() {
            costomCollider.onTriggerEnter2D.AddListener(this.OnTriggerEnter);
        }

        // Update is called once per frame
        void Update() {

        }

        private void OnTriggerEnter() {
            Debug.LogError("aaa");
        }

        private void OnMouseDown() {
            rigidbody.bodyType = RigidbodyType2D.Kinematic;
            rigidbody.velocity = new Vector2(0, 0);
            Debug.LogError("bbb");
        }

        private void OnMouseDrag() {
            rigidbody.velocity = new Vector2(0, 0);
            rigidbody.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        }

        private void OnMouseUp() {
            rigidbody.bodyType = RigidbodyType2D.Dynamic;
            rigidbody.velocity = new Vector2(0, 0);
            Debug.LogError("aaa");
        }
    }
}
