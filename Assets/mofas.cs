using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class mofas : MonoBehaviour
{
    //movimiento jugador
  public  Rigidbody2D rb;
    public Text tit;
    bool grounded = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-2, 0));

        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(2, 0));

        }
        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            rb.AddForce(new Vector2(0, 400f));
            grounded = false;

        }
        if (Input.GetKey(KeyCode.S) && grounded == false)
        {
            rb.AddForce(new Vector2(0, -10f));
            this.gameObject.tag = "attas";
        }
        else
        {

            this.gameObject.tag = "Player";
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        grounded = true;
    }
}
