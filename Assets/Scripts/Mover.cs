using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstuctions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstuctions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Use WASD to move");
        Debug.Log("Avoid the obstacles!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime *  moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
