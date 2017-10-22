using System;
using UnityEngine;
using System.IO;

public class SpinBounce : MonoBehaviour
{
    private float initY;

    public float spinSpeed;
    public float bounceHeight;
    public char spinAxis;
    

    // Use this for initialization
    void Start()
    {
        initY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        switch(Char.ToUpper(spinAxis))
        {
            case 'X':
                transform.Rotate(Vector3.right, spinSpeed * Time.deltaTime);
                break;

            case 'Y':
                transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
                break;

            case 'Z':
                transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
                break;

            default:
                break;
        }

        transform.position = new Vector3(transform.position.x, initY + ((float)Math.Sin(Time.time) * bounceHeight), transform.position.z);
    }
}

