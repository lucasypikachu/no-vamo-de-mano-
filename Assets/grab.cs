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
    public abils mom;
    public bool manos;
    public int combo;
    public float posis;
    public int div;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

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

                   combo += grabing.wuw(this.gameObject, posis / div);
                    div = 0;
                    posis = 0;
                }
            }
            else
            {
                if (div != 0)
                {
                    grabing = temporal;
                    grabing.wuw(this.gameObject, posis / div);

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
}
