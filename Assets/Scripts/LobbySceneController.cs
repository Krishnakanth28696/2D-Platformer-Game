using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbySceneController : MonoBehaviour
{
    public Button buttonStartAdventure;
    public GameObject showLevel;
    private void Awake()
    {
        buttonStartAdventure.onClick.AddListener(Level1SceneLoad);
    }

    private void Level1SceneLoad()
    {
        showLevel.SetActive(true);
    }
}
