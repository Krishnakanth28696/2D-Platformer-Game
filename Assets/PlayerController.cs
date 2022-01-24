using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
    public float speed, jump;
    Vector3 scale, position;
    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        bool crouch = Input.GetKey(KeyCode.LeftControl);
        PlayerMove(horizontal);
        PlayerJump(vertical);
        PlayerCrouch(crouch);


        void PlayerCrouch (bool crouch)
        {
            if (crouch)
            {
                animator.SetBool("Crouch", true);
            }
            else
            {
                animator.SetBool("Crouch", false);
            }
        }
        

        void PlayerJump(float vertical)
        {
            if (vertical > 0)
            {
                animator.SetBool("Jump", true);
                body.AddForce(new Vector2(0, jump), ForceMode2D.Force);

            }
            else
            {
                animator.SetBool("Jump", false);
            }
        }


        void PlayerMove(float horizontal)
        {
            //code to add player flip
            animator.SetFloat("Speed", Mathf.Abs(horizontal));
            scale = transform.localScale;
            scale.x = (horizontal < 0)?  -1f * Mathf.Abs(scale.x) : Mathf.Abs(scale.x);
            transform.localScale = scale;

            //code to add player movement
            position = transform.position;
            position.x += horizontal * speed * Time.deltaTime;
            transform.position = position;
        }

    }
}
