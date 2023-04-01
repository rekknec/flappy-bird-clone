using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class birdScript : MonoBehaviour

{
    public Rigidbody2D rb;
    public float flapStrength;
    public logicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && birdIsAlive) {

            rb.velocity = Vector2.up * flapStrength;
        }
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            killBird();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "danger")
        {
            killBird();
        }
    }

    void killBird()
    {
        if (birdIsAlive)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }
}
