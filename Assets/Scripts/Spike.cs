using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public AudioSource DeathSound;
    public GameObject Player;
    public float ResetX;
    public float ResetY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //function that checks for collision
    public void OnCollisionEnter2D(Collision2D col)
    {
        //checks to see if the colliosion is with Spike tag
        if (col.gameObject.tag == "Player")
        {
            //changes the scene to game2
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
            Vector3 newPos = new Vector3(ResetX, ResetY, transform.position.z);
            Player.transform.position = newPos;
            DeathSound.Play();
        }
    }
}
