using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public int vida;
    public float        moverHorizontal;
    public float        moverVertical;
    private Vector2     mover;
    public Rigidbody2D rb2d;
    public float        velocidade;


    // Start is called before the first frame update
    void Start()
    {
        vida = 100;
        velocidade = 2;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        // Pular
        if (Input.GetKeyDown(KeyCode.Space))
        {
            vida = vida - 1;
            //vida--;
            Debug.Log("Tecla de espaço pressionada. (Vida = " + vida + ")");
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 150));
            GetComponent<AudioSource>().Play();
        }

        
        // Mover
        // Edit / Project Settings / Input
        float moverHorizontal = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(moverHorizontal * velocidade, rb2d.velocity.y);

        //Rotacionar personagem
        if (moverHorizontal < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (moverHorizontal > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

    }

    void FixedUpdate()
    {

        
    }
}
