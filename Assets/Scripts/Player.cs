using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   float maxDesplazamiento = 4f;
    public float velocity = 10f;
    public float torque;
    private Rigidbody2D rb;
    Collider2D colliderCat;
    Animator animator;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        colliderCat = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) && transform.position.y <= maxDesplazamiento) {
            Vector3 newPosition = transform.position;
            newPosition += Vector3.up * velocity * Time.deltaTime;
            transform.position = newPosition;
        }
        if(Input.GetKey(KeyCode.S) && transform.position.y >= -maxDesplazamiento) {
            Vector3 newPosition = transform.position;
            newPosition += Vector3.down * velocity * Time.deltaTime;
            transform.position = newPosition;
        }

        /*if(Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = Vector2.up * velocity;
        }*/
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Enemy"){
            Debug.Log("enemy hit");
            animator.SetBool("IsCyan", true);
            animator.SetBool("IsYellow", false);
            animator.SetBool("IsPink", false);
            AddTorqueImpulse(90F);
            Health.instance.HeartSystem();
        }
        if(other.tag == "YellowStar"){
            animator.SetBool("IsYellow", true);
            animator.SetBool("IsPink", false);
            animator.SetBool("IsCyan", false);
            Debug.Log("the cat is yellow now");
        }
        else if(other.tag == "PinkStar"){
            animator.SetBool("IsPink", true);
            animator.SetBool("IsYellow", false);
            animator.SetBool("IsCyan", false);
            Debug.Log("the cat is pink now");
        }
        
    }
    public void AddTorqueImpulse(float angularChangeInDegrees)
    {
        var body = GetComponent<Rigidbody2D>();
        var impulse = (angularChangeInDegrees * Mathf.Deg2Rad) * body.inertia;

        body.AddTorque(impulse, ForceMode2D.Impulse);
    }
    
   
}
