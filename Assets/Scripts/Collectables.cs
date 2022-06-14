using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public float speed = 4.5f;
    public float points;
    private Rigidbody2D rb;
    private float limit = -8f;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < limit){
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("you have " + points + " points");
        Destroy(this.gameObject);
    }
}
