using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{

    [RequireComponent(typeof(Rigidbody2D))]

    public class PlayerScript : MonoBehaviour
    {

        public float playerSpeed = 4f
        void Start()
        {

        }

        void FixedUpdate()
        {
            Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            GetComponent<Rigidbody2D>().velocity = targetVelocity * playerSpeed;
        }
    }
}
