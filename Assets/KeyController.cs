using UnityEngine;

public class KeyController : MonoBehaviour
{
    //public ScoreController scoreController;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.GetComponent<PlayerController>() != null)
        {
            PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();
            playerController.pickUp();
            Destroy(gameObject);
        }
    }
}
