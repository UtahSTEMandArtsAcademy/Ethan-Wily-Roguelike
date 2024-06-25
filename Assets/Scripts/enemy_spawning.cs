using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawning : MonoBehaviour
{
    public GameObject[] enemies;
    private float timer;
    public float interval;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > interval)
        {
            Instantiate(enemies[Random.Range(0, enemies.Length)], new Vector2(Random.Range(-300, 300), Random.Range(-300, 300)), transform.rotation);
            timer = 0;
        }
    }
}
