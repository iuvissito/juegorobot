using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotmanager : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    Rigidbody2D rb;
    [SerializeField] float speed;
    [SerializeField] float maxspeed;
    [SerializeField] float desplX;
    [SerializeField] float jumpforce;
    bool ingrounder = true;
    bool alive;
    bool facingrigth = true;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        maxspeed = 2f;
        jumpforce = 5f;
        alive = true;
        ingrounder = true;

    }

    // Update is called once per frame
    void Update()
    {
        desplX = Input.GetAxis("Horizontal");
        Girar();
        Saltar();

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
    // lo de la bool es para que no este comprobando todo el rato a donde esta mirando
    void Girar()
    {
        if (desplX < 0 && facingrigth)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            facingrigth = false;
        }
        else if (desplX > 0 && !facingrigth)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            facingrigth = true;
        }

    }
    void Saltar()
        // de momento no me salta con el animator.getbool debo crear una collide que me indique que ingrounder = true codigo profe
    {
        if (Input.GetKeyDown(KeyCode.Space) && animator.GetBool("ingrounder") == true)

        {
            
            print("www");
            rb.AddForce(new Vector2(0f, 1f) * jumpforce, ForceMode2D.Impulse);
            animator.SetTrigger("jump");
            
            ;
        }
        
    }
}

