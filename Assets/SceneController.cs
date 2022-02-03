using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void deadSceneLoad()
    {
        SceneManager.LoadScene("Dead");
    }

    public void Level2SceneLoad()
    {
        SceneManager.LoadScene("Two");
    }
}
