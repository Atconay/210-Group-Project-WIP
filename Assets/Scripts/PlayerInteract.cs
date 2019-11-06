using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteract : MonoBehaviour
{
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
        //checks to see if the colliosion is with Gate tag
        if (col.gameObject.tag == "Gate")
        {
            //changes the scene to game2
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        //checks to see if the colliosion is with PickUp tag
        if (col.gameObject.tag == "PickUp")
        {
            //changes the scene to game2
            Debug.Log("OOF");
        }

    }
}
