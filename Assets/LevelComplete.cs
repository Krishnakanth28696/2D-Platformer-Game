using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public SceneController controller;
    public ScoreController scoreController;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            Debug.Log("Level Completed");
            //SceneManager.LoadScene("Two");
            controller.Level2SceneLoad();
            /*scoreController.RefreshUI();
            if (scoreController.score == 30)
            {
                controller.Level2SceneLoad();
            }*/
        }
    }
}
