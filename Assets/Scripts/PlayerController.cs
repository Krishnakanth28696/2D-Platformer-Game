using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Other scripts
    public GroundCheck groundCheck;
    public DeathFall deathFall;
    public EnemyController enemyController;
    public LevelStart levelStart;
    public ScoreController scoreController;
    public HealthController healthController;

    // Local
    public Animator animator;
    public float speed, jump;
    Vector3 scale, position;
    private Rigidbody2D body;
    public bool enemyIsAttack;
    

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        bool crouch1 = Input.GetKeyDown(KeyCode.LeftControl);
        bool crouch2 = Input.GetKeyUp(KeyCode.LeftControl);
        PlayerMove(horizontal);
        PlayerJump(vertical);
        PlayerCrouch(crouch1, crouch2);
        


        void PlayerCrouch (bool crouch1, bool crouch2)
        {
            if (crouch1)
            {
                animator.SetBool("Crouch", true);

            }
            else if (crouch2)
            {
                animator.SetBool("Crouch", false);
            }
        }
        

        void PlayerJump(float vertical)
        {
            if (vertical > 0 && groundCheck.isGrounded == true)
            {
                animator.SetBool("Jump", true);
                body.velocity = new Vector2(body.velocity.x, jump);
                //body.AddForce(new Vector2(0, jump), ForceMode2D.Force);
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

    public void enemyAttack()
    {
        enemyIsAttack = true;
    }
    public void PlayerResurrect()
    {
        if (deathFall.isFallen == true || enemyIsAttack == true)
        {
            Debug.Log(position);
            animator.SetBool("DeathFall", true);
            position = new Vector3(-2.12f, 10f, 0f);
            transform.position = position;
            DecreaseHealth();
            enemyIsAttack = false;
        }
        else if (deathFall.isFallen == false || enemyController.isAttacked == false)
        {
            animator.SetBool("DeathFall", false);
        }
        
    }

    public void pickUp()
    {
        scoreController.IncreaseScore(10);
    }

    public void DecreaseHealth()
    {
        healthController.DecreaseHeart(1);
    }

}
