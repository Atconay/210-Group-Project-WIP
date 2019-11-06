using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLedge : MonoBehaviour
{
    public float X1;
    public float X2;
    public float Speed = .2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetFloat("Paused") > 0)
        {
            Vector3 newPos = new Vector3(transform.position.x + Speed, transform.position.y, transform.position.z);
            transform.position = newPos;
        }

        if (transform.position.x < X1)
        {
            Speed = -Speed;
        }

        if (transform.position.x > X2)
        {
            Speed = -Speed;
        }
    }
}
