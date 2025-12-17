using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class grub :  enemies
{
    public grab longa;
    public override void wuw(GameObject launcher, float anglo, bool evil)
    {
        float xix = 2.15f*Mathf.Cos(anglo * Mathf.Deg2Rad);
        float yiy = 2.15f*Mathf.Sin(anglo * Mathf.Deg2Rad);
        Vector3 nin = new Vector3(launcher.transform.position.x + xix, launcher.transform.position.y + yiy, launcher.transform.position.z);

        longa = launcher.GetComponent<grab>();
        float angleRad = anglo * Mathf.Deg2Rad;




        Vector2 direction = new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad));

        Debug.DrawRay(nin, direction* 100f, Color.red);

        RaycastHit2D hit = Physics2D.Raycast(nin, direction, 100f);


        if (Physics2D.Raycast(nin, direction, 100f) == true) {

                if (hit.collider.tag == "mon")
                {
                grab.comobo(1,0);
                    longa.mom = hit.collider.GetComponent<abils>();
                    longa.grabing = longa.mom.sis;
                    longa.manos = true;

                }

            

        }
    }
    
}

