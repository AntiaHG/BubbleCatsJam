using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 6f;
    private Rigidbody2D rb;
    private float limit = -7.32f;
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
}
