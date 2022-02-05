using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DeadSceneController : MonoBehaviour
{
    public Button buttonPlayAgain;
    private void Awake()
    {
        buttonPlayAgain.onClick.AddListener(Level1SceneLoad);
    }

    private void Level1SceneLoad()
    {
        SceneManager.LoadScene("Showcase");
    }
}
