using UnityEngine;

public class DeathFall : MonoBehaviour
{
    public bool isFallen;
    public PlayerController controller;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            Debug.Log("Player has fallen and going to its starting position");
            isFallen = true;
            controller.PlayerResurrect();
        }
    }
}
