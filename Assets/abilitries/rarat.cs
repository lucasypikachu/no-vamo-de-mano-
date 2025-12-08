using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class rarat : enemies
{
    //crea una pelota
    Rigidbody2D momimo;
    
   Rigidbody2D momimo2;
    public override void wuw(GameObject launcher, float anglo)
    {
        float xix = 2.15f * Mathf.Cos(anglo * Mathf.Deg2Rad);
        float yiy = 2.15f * Mathf.Sin(anglo * Mathf.Deg2Rad);
        Vector3 nin = new Vector3(launcher.transform.position.x + xix, launcher.transform.position.y + yiy, launcher.transform.position.z);

        float angleRad = anglo * Mathf.Deg2Rad;




        Vector2 direction = new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad));

        Debug.DrawRay(nin, direction * 1000f, Color.red);

        RaycastHit2D hit = Physics2D.Raycast(nin, direction, 1000f);


        if (Physics2D.Raycast(nin, direction, 1000f) == true)
        {

            if (hit.collider.tag == "mon")
            {
               momimo = hit.collider.gameObject.GetComponent<Rigidbody2D>();
                nin = launcher.transform.position;
                launcher.transform.position = hit.transform.position;
                hit.transform.position = nin;
                momimo.AddForce(new Vector2(xix * -100, yiy * -100));
                momimo2 =launcher.GetComponent<Rigidbody2D>();
                momimo2.AddForce(new Vector2(xix *100, yiy * 100));
                
            }



        }

    }
}
