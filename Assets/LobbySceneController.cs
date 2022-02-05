using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbySceneController : MonoBehaviour
{
    public Button buttonStartAdventure;
    private void Awake()
    {
        buttonStartAdventure.onClick.AddListener(Level1SceneLoad);
    }

    private void Level1SceneLoad()
    {
        SceneManager.LoadScene("Showcase");
    }
}
