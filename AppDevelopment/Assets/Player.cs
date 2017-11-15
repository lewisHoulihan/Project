using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    Animator myAnimator;
    private bool facingRight = true;
    public float speed = 10;

    void Start()
    {
        //ref to animator body in game
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        myAnimator.SetFloat("speed", Mathf.Abs(horizontal));
        transform.Translate(Time.deltaTime * (speed * horizontal), 0, 0);
        Flip(horizontal);

    }
    void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;
            SpriteRenderer flipX = GetComponent<SpriteRenderer>();
            flipX.flipX= !facingRight;
        }

        // Multiply the player's x local scale by -1

    }
}
	

