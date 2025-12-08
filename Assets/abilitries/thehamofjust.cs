using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class thehamofjust : enemies
{
   public GameObject hamington;
    BoxCollider2D coc;
    public override void wuw(GameObject launcher, float anglo)
    {
        coc = launcher.GetComponent<BoxCollider2D>();
        float xix = 2.35f * Mathf.Cos(anglo * Mathf.Deg2Rad);
        float yiy =  2.35f * Mathf.Sin(anglo * Mathf.Deg2Rad);
        Quaternion niniom = hamington.transform.rotation;
        Instantiate(hamington, new Vector3(launcher.transform.position.x + xix, launcher.transform.position.y + yiy, launcher.transform.position.z),niniom ,launcher.transform );
        
    }
}
