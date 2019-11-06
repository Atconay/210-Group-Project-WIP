using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    //declares the speed of the player
    public float moveSpeed = 7.5f;

    //declares a float for the jump height
    public float jump = 400f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //checks for the Arrow key input and moves the player in the respective direction

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            //flips the sprite to the right
            this.GetComponent<SpriteRenderer>().flipX = false;
        }


        //checks 
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            //flips the sprite to the left
            this.GetComponent<SpriteRenderer>().flipX = true;

        }

        //checks to see if the player is on the ground and the player is pressing space
        if (GetComponent<Rigidbody2D>().velocity.y == 0f && Input.GetKeyDown(KeyCode.Space))
        {
            //makes the character jump in the air
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump));
        }

    }
}
