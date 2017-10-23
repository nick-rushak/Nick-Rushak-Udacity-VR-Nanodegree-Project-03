using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab

    public ParticleSystem particleSystem;
    public AudioSource audioSource;


    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy

        RaycastHit rch;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out rch))
        {
            BoxCollider bc = rch.collider as BoxCollider;

            particleSystem.Play();
            audioSource.Play();

            if (bc != null && bc.gameObject.name == "Coin")
            {    
               Destroy(bc.gameObject, particleSystem.main.duration + .75f);
            }
        }
    }
}