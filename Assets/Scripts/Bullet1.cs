using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public Joueur monCreateur;
    public GameObject monCrystal;
    public GameObject monCrystal10;
    public GameObject monCrystal100;
    public GameObject monCrystal1000;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
        //monCreateur = FindObjectOfType<Joueur>();
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
        myRigidbody.velocity = Vector3.up*speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int monrandom = Random.Range(0, 1001);
        if (monCreateur.Plus <= 0)
        {
            if (monrandom < 450)
            {
                Instantiate(monCrystal, transform.position, transform.rotation);
            }
            if (monrandom >= 450 & monrandom <= 820)
            {
                Instantiate(monCrystal10, transform.position, transform.rotation);
            }
            if (monrandom >= 820 & monrandom <= 970)
            {
                Instantiate(monCrystal100, transform.position, transform.rotation);
            }
            if (monrandom > 970)
            {
                Instantiate(monCrystal1000, transform.position, transform.rotation);
            }
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (monCreateur.Plus == 1)
        {
            if (monrandom < 350)
            {
                Instantiate(monCrystal, transform.position, transform.rotation);
            }
            if (monrandom >= 350 & monrandom <= 680)
            {
                Instantiate(monCrystal10, transform.position, transform.rotation);
            }
            if (monrandom >= 680 & monrandom <= 920)
            {
                Instantiate(monCrystal100, transform.position, transform.rotation);
            }
            if (monrandom > 920)
            {
                Instantiate(monCrystal1000, transform.position, transform.rotation);
            }
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (monCreateur.Plus == 2)
        {
            if (monrandom < 250)
            {
                Instantiate(monCrystal, transform.position, transform.rotation);
            }
            if (monrandom >= 250 & monrandom <= 580)
            {
                Instantiate(monCrystal10, transform.position, transform.rotation);
            }
            if (monrandom >= 580 & monrandom <= 850)
            {
                Instantiate(monCrystal100, transform.position, transform.rotation);
            }
            if (monrandom > 850)
            {
                Instantiate(monCrystal1000, transform.position, transform.rotation);
            }
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (monCreateur.Plus == 3)
        {
            if (monrandom >= 0 & monrandom <= 430)
            {
                Instantiate(monCrystal10, transform.position, transform.rotation);
            }
            if (monrandom >= 430 & monrandom <= 790)
            {
                Instantiate(monCrystal100, transform.position, transform.rotation);
            }
            if (monrandom > 790)
            {
                Instantiate(monCrystal1000, transform.position, transform.rotation);
            }
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (monCreateur.Plus == 4)
        {
            if (monrandom >= 0 & monrandom <= 280)
            {
                Instantiate(monCrystal10, transform.position, transform.rotation);
            }
            if (monrandom >= 280 & monrandom <= 650)
            {
                Instantiate(monCrystal100, transform.position, transform.rotation);
            }
            if (monrandom > 650)
            {
                Instantiate(monCrystal1000, transform.position, transform.rotation);
            }
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

    }
}
