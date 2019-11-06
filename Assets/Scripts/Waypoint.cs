using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public Transform[] next;
    public float speed = 100f;

    private int current; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != next[current].position)
        {
            Vector2 slime = Vector2.MoveTowards(transform.position, next[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody2D>().MovePosition(slime);
        }
        else
        {
            current = (current + 1) % next.Length;
        }
    }
}
