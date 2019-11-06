using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCollision : MonoBehaviour
{
    public AudioSource first;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            count++;

            if (count == 1)
            {
                first.Play();
            }
        }
    }
}
