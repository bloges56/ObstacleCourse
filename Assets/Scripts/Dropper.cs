using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidBody;
    [SerializeField] private int waitTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;

        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= waitTime)
        {
            renderer.enabled = true;
            rigidBody.useGravity = true;
            Debug.Log(waitTime + " seconds has elapsed.");
        }
    }
}
