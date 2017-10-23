using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public ParticleSystem particleSystem;
    public AudioSource audioSource;
    public Door lockedDoor;

    void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

    public void OnKeyClicked()
	{
        RaycastHit rch;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        lockedDoor.locked = false;

        if (Physics.Raycast(ray, out rch))
        {
            BoxCollider bc = rch.collider as BoxCollider;

            particleSystem.Play();
            audioSource.Play();

            if (bc != null && bc.gameObject.name == "Key")
            {
                Destroy(bc.gameObject, particleSystem.main.duration + 2f);
            }
        }

    }

}
