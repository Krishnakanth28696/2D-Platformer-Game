using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //Other Script
    public HealthController health;
    public PlayerController controller;

    //Local
    public float speed;
    public Transform xEnd;
    public Rigidbody2D rb;
    private bool mustMove, mustTurn;
    public LayerMask groundLayer;
    public BoxCollider2D bCollider;
    public bool isAttacked;
    
    void Start()
    {
        mustMove = true;
    }

    private void Update()
    {
        if (mustMove)
        {
            patrol();
        }
    }

    private void FixedUpdate()
    {
        if (mustMove)
        {
            mustTurn = !Physics2D.OverlapCircle(xEnd.position, 0.1f, groundLayer);
        }
    }

    void patrol()
    {
        if (mustTurn || bCollider.IsTouchingLayers(groundLayer)) 
        {
            flip();
        }
        rb.velocity = new Vector2(speed * Time.fixedDeltaTime, rb.velocity.y);
    }

    void flip()
    {
        mustMove = false;
        transform.localScale = new Vector2(-1 * transform.localScale.x, transform.localScale.y);
        speed *= -1;
        mustMove = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            Debug.Log("Player has fallen and going to its starting position");
            isAttacked = true;
            //controller.DecreaseHealth();
            controller.enemyAttack();
            controller.PlayerResurrect();
        }
    }
}



