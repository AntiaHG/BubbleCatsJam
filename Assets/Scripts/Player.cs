using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity = 3f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            //Jump
            rb.velocity = Vector2.up * velocity;
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("hit detected");
    }
}
