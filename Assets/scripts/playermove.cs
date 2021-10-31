using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public float speed = 1f;
    public Rigidbody2D rb;
    Vector2 movement;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }
    void FixedUpdate()
    {
        //Função que faz o rb se mover de acordo com o controle vezes a velocidade
        rb.MovePosition(rb.position + movement * speed);
    }
}

