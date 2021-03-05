using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int score = 0;
    private void OnCollisionEnter(Collision other) 
    {
        if( other.gameObject.name != "Plane"  && other.gameObject.tag != "Hit")
        {
            score += 1;
            Debug.Log($"You've bumped into a thing this many times: {score}");
        }
    }
}
