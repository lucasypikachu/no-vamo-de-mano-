using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class grab : MonoBehaviour
{
    //habilidades jugador
    public enemies grabing;
    public enemies temporal;
    public static float tiempos;
    public abils mom;
    public bool manos;
    public static int combo;
    public static int[] usos = new int[5];
    public float posis;
    public int div;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        tiempos -= Time.deltaTime / 2;
        if (tiempos <= 0)
        {
            tiempos = 0;
            combo = 0;
            usos[0] = 0;
            usos[1] = 0;
            usos[2] = 0;
            usos[3] = 0;
            usos[4] = 0;

        }

        posis = 0;
        div = 0;
        if (Input.GetKey("right"))
        {
            if (!Input.GetKey("left"))
            {

                div++;
                posis += 0;
            }
        }
        if (Input.GetKey("left"))
        {
            if (!Input.GetKey("right")) {

                div++;

                posis += 180;
            }
           


        }

        if (Input.GetKey("up"))
        {
            div++;
            posis += 90;

        }
        if (Input.GetKey("down"))
        {
            div++;
            if (Input.GetKey("left")) {

                posis += 270;
            }
            else
            {
                posis -= 90;
            }
        }
       
        if (Input.GetKeyDown("right") || Input.GetKeyDown("left") || Input.GetKeyDown("up") || Input.GetKeyDown("down"))
        {
            Debug.Log(posis / div);
            if (manos == true)
            {
                if (div != 0)
                {

               grabing.wuw(this.gameObject, posis / div,false);
                    div = 0;
                    posis = 0;
                }
            }
            else
            {
                if (div != 0)
                {
                    grabing = temporal;
                    grabing.wuw(this.gameObject, posis / div, false);

                    div = 0;
                    posis = 0;
                        }
            }
            
        }
        if (Input.GetKeyDown("space"))
        {
            manos = false;
        }



    }
    public static void comobo(int numero, int cual)
    {
        Debug.Log("fufnfos");
        usos[cual]++;
        combo += numero / usos[cual];

       tiempos += numero.ConvertTo <float > () / usos[cual];


    }
    public int heala;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "attas")
        {
            heala--;
        }
        if (heala <= 0)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "attas")
        {
            heala--;
        }
        if (heala <= 0)
        {
            Destroy(gameObject);
        }

    }
}
