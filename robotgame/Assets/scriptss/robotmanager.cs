using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotmanager : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    Rigidbody2D rb;
    float speed;
    float maxspeed;
    float desplX;
    bool alive = true;
    bool facingrigth = true;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        maxspeed = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        desplX = Input.GetAxis("Horizontal");
        Girar();
    }
    private void FixedUpdate()
    {
       
        Caminar();
        
    }
    void Caminar()
    {
        rb.velocity = new Vector2(desplX * maxspeed, rb.velocity.y);
        speed = Mathf.Abs(speed);
        animator.SetFloat("speedx", speed);
        speed = rb.velocity.x;
        print(speed);
    }
    // codigo bruto flipear 
    void Girar()
    { 
        if (desplX < 0 && facingrigth)
        {
            transform.localScale = new Vector3(-1f, 1f,1f);
            facingrigth = false;
        }
        else if (desplX > 0 && !facingrigth)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            facingrigth = true;
        }
    }
}
