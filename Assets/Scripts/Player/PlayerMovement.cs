using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    [SerializeField] float speed = 5f;
    [SerializeField] Animator leftExhaustAnim;
    [SerializeField] Animator rightExhaustAnim;

    void Awake()
    {
        if (Time.timeScale == 0f)
            Time.timeScale = 1f;
    }
	// Update is called once per frame
	void Update () 
    {
        float moveForward = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float moveRight = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        Vector2 move = new Vector2(moveRight, moveForward);

        transform.Translate(move);

        UpdateExhaustAnimation(moveForward, moveRight);
	}

    void UpdateExhaustAnimation(float forward, float right)
    {
        if (forward > 0 || right > 0)
        {
            leftExhaustAnim.SetFloat("speed", 1f);
            rightExhaustAnim.SetFloat("speed", 1f);
        }
        else
        {
            leftExhaustAnim.SetFloat("speed", 0f);
            rightExhaustAnim.SetFloat("speed", 0f);
        }
    }
}
