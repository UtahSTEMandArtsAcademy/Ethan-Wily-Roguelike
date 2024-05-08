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
    public GameObject player;
    private float speed;
    public float health;
    public AnenomeStats STATS;
    public aiTypes ai;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("player");
        checkStats();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = (player.transform.position - transform.position).normalized;
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
            float dist = Vector2.Distance(player.transform.position, transform.position);
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
        if(health < 1)
        {
            Destroy(this.gameObject);
        }
    }
    public void checkStats()
    {
        switch (ai)
        {
            case aiTypes.SingleShot:
                speed = STATS.speed;
                health = STATS.health;
                break;

            case aiTypes.MultiShot:
                speed = STATS.speed;
                health = STATS.health;
                break;

            case aiTypes.Foof:
                health = STATS.health;
                
                    speed = STATS.speed;
                break;
        }
    }
}
