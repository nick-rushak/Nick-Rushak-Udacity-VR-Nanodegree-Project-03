using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public ParticleSystem particleSystem;
    public AudioSource audioSource;
    public GameObject key;
    public Door lockedDoor;

    void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

    public void OnKeyClicked()
	{
        lockedDoor.locked = false;
        particleSystem.Play();
        audioSource.Play();
        Destroy(key, particleSystem.main.duration +2f);
    }

}
