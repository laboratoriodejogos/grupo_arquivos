using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public int vida;

    // Start is called before the first frame update
    void Start()
    {
        vida = 100;    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            vida = vida - 1;
            //vida--;
            Debug.Log("Tecla de espaço pressionada. (Vida = " + vida + ")");
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 150));

        }
    }
}
