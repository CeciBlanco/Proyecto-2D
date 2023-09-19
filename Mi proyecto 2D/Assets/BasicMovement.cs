using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public float walkingSpeed;
    public Rigidbody2D cuerpo;


    private void Start()
    {
        cuerpo = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector2 movimiento = ((Vector2.right * horizontal) + (Vector2.up * vertical)) * walkingSpeed;

        //transform.position += new Vector3(movimiento.x, movimiento.y, 0) * Time.deltaTime;
        cuerpo.velocity = new Vector2(movimiento.x,movimiento.y) * Time.deltaTime;

    }
}
