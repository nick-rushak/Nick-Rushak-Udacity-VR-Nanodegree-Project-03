using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab

    public ParticleSystem particleSystem;
    public AudioSource audioSource;
    public GameObject coin;


    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
        particleSystem.Play();
        audioSource.Play();
        Destroy(coin, particleSystem.main.duration + .75f);
    }
}