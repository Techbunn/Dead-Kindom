using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour {

    private float speed;

    private Vector2 direction;
    // Use this for initialization
    void Start() {
        direction = Vector2.up;
    }

    // Update is called once per frame
    void Update() {
        Move();
    }
    public void Move()
    {
        transform.Translate(direction*speed*Time.deltaTime);

    }
}
