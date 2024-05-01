using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PewPewScript : MonoBehaviour
{
    public PlayerData STATS;
    private float fireCooldown = 0;
    public GameObject pewPewBullet;
    public GameObject firepoint;

    void Update()
    {
        fireCooldown = Mathf.Max(fireCooldown - Time.deltaTime, 0);
    }

    // Update is called once per frame
    public void Shoot()
    {
        if(fireCooldown == 0){
            Rigidbody2D bullet = Instantiate(pewPewBullet, firepoint.transform.position, transform.rotation).GetComponent<Rigidbody2D>();
            bullet.AddForce(transform.up * STATS.bulletSped);
            Destroy(bullet.gameObject, STATS.bullitLife);
            fireCooldown = STATS.relaod;
        }
    }
}
