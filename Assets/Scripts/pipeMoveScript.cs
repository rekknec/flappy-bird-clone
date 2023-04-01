using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -30;
    public birdScript bird;

    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("bird").GetComponent<birdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bird.birdIsAlive)
        {
            transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        }
        
        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
