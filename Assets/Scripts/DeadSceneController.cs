using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DeadSceneController : MonoBehaviour
{
    public Button buttonPlayAgain;
    private void Awake()
    {
        buttonPlayAgain.onClick.AddListener(ReLoadScene);
    }

    private void ReLoadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }
}
