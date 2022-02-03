using UnityEngine;

public class LevelStart : MonoBehaviour
{
    public PlayerController controller;
    public DeathFall deathFall;
    public EnemyController enemyController;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            //Debug.Log("Level Is Started");
            deathFall.isFallen = false;
            enemyController.isAttacked = false;

            controller.PlayerResurrect();
        }
    }
}
