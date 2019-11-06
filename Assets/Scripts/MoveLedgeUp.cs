using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLedgeUp : MonoBehaviour
{
    public float Y1;
    public float Y2;
    public float SpeedY = .1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetFloat("Paused") > 0)
        {
            Vector3 newPos = new Vector3(transform.position.x, transform.position.y + SpeedY, transform.position.z);
            transform.position = newPos;
        }

        if (transform.position.y < Y1)
        {
            SpeedY = -SpeedY;
        }

        if (transform.position.y > Y2)
        {
            SpeedY = -SpeedY;
        }
    }
}
