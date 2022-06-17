using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity = 3f;
    public float torque;
    public GameObject yellowCat;
    public GameObject pinkCat;
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
        if(Input.GetKeyDown(KeyCode.Space)){
            //Jump
            rb.velocity = Vector2.up * velocity;
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Enemy"){
            Debug.Log("enemy hit");
            AddTorqueImpulse(90F);
            Health.instance.HeartSystem();
        }
        if(other.tag == "YellowStar"){
            //rb.velocity = Vector3.zero;
            animator.SetBool("IsYellow", true);
            Debug.Log("the cat is yellow now");
        }
        else if(other.tag == "PinkStar"){
            animator.SetBool("IsPink", true);
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
