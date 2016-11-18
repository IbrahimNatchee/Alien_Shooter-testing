using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

    //Public Variables for testing

    //Step 1.2 identifying the public audiosource variable of shooting
    public AudioSource RifleShotSound;

    //we want to hear the left mouse to hear the sound



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    //Step 1 of coding for the firing sound, first we changed the updates method to fixed update because it works better.
	void FixedUpdate () {

        //1.3 everytime we click the right click on the mouse we hear the firing shots, it'll make the sound not actually fire anything
        //Fire1 is the left mouse button and also the controller button, if you need to know what controller button is connected to what, go to unity
        //click on Edit-->Projectsettings-->Input-->you see the input manager.
        if (Input.GetButtonDown("Fire1")){
            //play Rifle sound
            this.RifleShotSound.Play();
        }

	}
}
