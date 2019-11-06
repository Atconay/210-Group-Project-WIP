using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    //creates a game objects to put the pause menu that fills the screen

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //creates a function that is called from a button in game
    public void BackGame()
    {
        //changes the scene to the menu scene
        SceneManager.LoadScene("MainMenu");
    }

    //creates a function that is called from a button in game

    public void PlayGame()
    {
        //changes the scene to the Game scene
        SceneManager.LoadScene("Lvl1");
    }

}
