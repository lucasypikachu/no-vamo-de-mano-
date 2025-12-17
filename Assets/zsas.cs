using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zsas : MonoBehaviour
{
    public Transform jugador; 
    public float distanciaAtaque = 0.1f;
    public GameObject monedas;
    public GameObject ratata;
    public GameObject bwarf;
    BoxCollider2D bombs;
    Rigidbody2D rb;
    int s;
    float timer;
    Vector3 poop;
    // Start is called before the first frame update public Transform jugador; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bombs = GetComponent<BoxCollider2D>();

        monedas.SetActive(false);
        rb.sharedMaterial.bounciness = 0.5f;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(transform.position, jugador.position);
        timer += Time.deltaTime;

        // Si está suficientemente cerca, ataca
        if (5.1f <= timer)
        {
            if (distancia <= distanciaAtaque)
            {
                timer = 0;
                Atacar();
            }

        }

    }
    public void Atacar()
    {
        s = Random.Range(1, 5);
        
        Debug.Log(s);
        switch (s)
        {
            case 1:
                StartCoroutine("attac1");
                break;
            case 2:
                StartCoroutine("attac2");
                break;
            case 3:
                attac3();
                break;
            case 4:
                StartCoroutine("attac4");
                break;
        }
    }
    IEnumerator attac1()
    {
        int anglo = Random.Range(1, 181);
        float xix = 1000 * Mathf.Cos(anglo * Mathf.Deg2Rad);
        float yiy = 1000 * Mathf.Sin(anglo * Mathf.Deg2Rad);

        rb.AddForce(new Vector2(xix, yiy));
        rb.sharedMaterial.bounciness = 2.0f;
        this.gameObject.tag = "attas";
        yield return new WaitForSeconds(5f);
        rb.sharedMaterial.bounciness = 0.5f;
        this.gameObject.tag = "mon";

    }
    IEnumerator attac2()
    {

        rb.gravityScale = -0.5f;
        poop = new Vector3(this.transform.position.x, this.transform.position.y - 1, this.transform.position.z);
        Instantiate(bwarf, poop, this.transform.rotation);
        yield return new WaitForSeconds(1f);
        poop = new Vector3(this.transform.position.x, this.transform.position.y - 1, this.transform.position.z);
        Instantiate(bwarf, poop, this.transform.rotation);
        yield return new WaitForSeconds(1f);
        poop = new Vector3(this.transform.position.x, this.transform.position.y - 1, this.transform.position.z);
        Instantiate(bwarf, poop, this.transform.rotation);
        yield return new WaitForSeconds(1f);
        poop = new Vector3(this.transform.position.x, this.transform.position.y - 1, this.transform.position.z);
        Instantiate(bwarf, poop, this.transform.rotation);
        yield return new WaitForSeconds(1f);
        poop = new Vector3(this.transform.position.x, this.transform.position.y -1, this.transform.position.z);
        Instantiate(bwarf, poop, this.transform.rotation);
        yield return new WaitForSeconds(1f);
        poop = new Vector3(this.transform.position.x, this.transform.position.y - 1, this.transform.position.z);
        rb.gravityScale = 1f;
        Instantiate(bwarf, poop, this.transform.rotation);
        int anglo = Random.Range(1, 181);
        float xix = 1000 * Mathf.Cos(anglo * Mathf.Deg2Rad);
        float yiy = 1000 * Mathf.Sin(anglo * Mathf.Deg2Rad);

        rb.AddForce(new Vector2(xix, yiy));

    }
    void attac3()
    {
        Instantiate(ratata, new Vector3(Random.Range(88f, 118), 17, transform.position.z), transform.rotation);
        Instantiate(ratata, new Vector3(Random.Range(88f, 118), 17, transform.position.z), transform.rotation);
        Instantiate(ratata, new Vector3(Random.Range(88f, 118), 17, transform.position.z), transform.rotation);
        Instantiate(ratata, new Vector3(Random.Range(88f, 118), 17, transform.position.z), transform.rotation);

    }
    IEnumerator attac4()
    {
        monedas.SetActive(true);
        this.gameObject.tag = "attas";
        bombs.enabled = false;
        rb.gravityScale = 0f;
        rb.velocity = Vector3.zero;
        transform.position = new Vector3(Random.Range(88f, 118), 14, transform.position.z);
        yield return new WaitForSeconds(1);
        rb.velocity = Vector3.zero;
        transform.position = new Vector3(transform.position.x, 16.6f, transform.position.z);
        rb.gravityScale = -0.5f;
        bombs.enabled = true;
        yield return new WaitForSeconds(0.5f);
        rb.velocity = Vector3.zero;
        monedas.SetActive(true);
        bombs.enabled = false;
        rb.gravityScale = 0f;
        rb.velocity = Vector3.zero;
        transform.position = new Vector3(Random.Range(88f, 118), 14, transform.position.z);
        yield return new WaitForSeconds(1);
        rb.velocity = Vector3.zero;
        transform.position = new Vector3(transform.position.x, 16.6f, transform.position.z);
        rb.gravityScale = -0.5f;
        bombs.enabled = true;
        yield return new WaitForSeconds(0.5f);
        bombs.enabled = false;
        rb.gravityScale = 0f;
        rb.velocity = Vector3.zero;
        rb.velocity = Vector3.zero;
        transform.position = new Vector3(Random.Range(88f, 118), 14, transform.position.z);
        yield return new WaitForSeconds(1);
        rb.velocity = Vector3.zero;
        transform.position = new Vector3(transform.position.x, 16.6f, transform.position.z);
        rb.gravityScale = -0.5f;
        bombs.enabled = true;
        yield return new WaitForSeconds(1);
        rb.gravityScale = 1f;
        this.gameObject.tag = "mon";
        monedas.SetActive(false);

    }
}
