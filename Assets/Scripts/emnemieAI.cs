using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum aiTypes
{
    SingleShot,
    MultiShot,
    Foof
    
}
[RequireComponent(typeof(Rigidbody2D))]
public class emnemieAI : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform player;
    private float speed;
    public AnenomeStats STATS;
    public aiTypes ai;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        transform.up = direction;
        rb.AddForce(direction * speed * Time.deltaTime);
        switch(ai)
        {
            case aiTypes.SingleShot:
            speed = STATS.speed;
            break;

            case aiTypes.MultiShot:
            speed = STATS.speed;
            break;

            case aiTypes.Foof:
            float dist = Vector2.Distance(player.position, transform.position);
            if(dist < STATS.chargeRadius)
            {
                speed = STATS.chargeSpeed;
            }
            else 
            {
                speed = STATS.speed;
            }
            break;
        }
    }
}
