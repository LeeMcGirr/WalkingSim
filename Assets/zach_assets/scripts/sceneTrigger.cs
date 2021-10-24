using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTrigger : MonoBehaviour
{
    public string sceneToLoad; //sets a input box in the unity editor for fast scene selection

    void Start()
    {
        //i don't think we need anything here, but we could put a prompt like "Press E to Interact"
    }

    
    void OnTriggerStay(Collider plr) //checks if collider (set below) is present inside trigger zone
    {
        if (plr.gameObject.tag == "Player") //sets plr as the game object with the tag Player
        {
            SceneManager.LoadScene(sceneToLoad);
            
            // if(Input.GetButtonDown("Submit")) //i've set Submit as "E" key in project -> input settings
            // {
            //     //print("IM ALIVE");
            //     SceneManager.LoadScene(sceneToLoad); //loads the scene selected in the unity editor
            // }
        }
    }
    
}
