using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    [SerializeField] float speed = 5f;

	// Update is called once per frame
	void Update () 
    {
        float moveForward = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float moveRight = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        Vector2 move = new Vector2(moveRight, moveForward);

        transform.Translate(move);
	}
}
