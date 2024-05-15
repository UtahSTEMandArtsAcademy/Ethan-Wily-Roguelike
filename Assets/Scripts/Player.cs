using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public  PlayerData stats;
    public Rigidbody2D hahaRigidbodyGoBrr;
    public PewPewScript gun;
    // Start is called before the first frame update
    void Start()
    {
        hahaRigidbodyGoBrr=GetComponent<Rigidbody2D>();
        stats.health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        float verticalAxis = Input.GetAxisRaw("Vertical");
        hahaRigidbodyGoBrr.velocity = new Vector2(horizontalAxis, verticalAxis).normalized * stats.speed;
        Vector2 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mouseScreenPosition - (Vector2)transform.position).normalized;
        transform.up = direction;
        
        if(Input.GetButton("Fire1"))
        {
            gun.Shoot();
        }
        if (stats.health == 0)
        {
            Destroy(this.gameObject);
        }
    }

   
}
