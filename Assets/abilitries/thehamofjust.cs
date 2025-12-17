using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class thehamofjust : enemies
{
   public GameObject hamington;
    BoxCollider2D coc;
    public override void wuw(GameObject launcher, float anglo, bool evil)
    {
        coc = launcher.GetComponent<BoxCollider2D>();
        float xix = coc.size.x * Mathf.Cos(anglo * Mathf.Deg2Rad);
        float yiy = coc.size.y * Mathf.Sin(anglo * Mathf.Deg2Rad);
        Quaternion niniom = hamington.transform.rotation;
        niniom.eulerAngles = new Vector3(0,0,anglo);
        Instantiate(hamington, new Vector3(launcher.transform.position.x + xix + coc.offset.x, launcher.transform.position.y + yiy + coc.offset.y, launcher.transform.position.z),niniom ,launcher.transform );

        
    }
}
