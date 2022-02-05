using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public Button buttonPause, buttonRestart, buttonCancel;
    public GameObject optionsPanel;
    private void Awake()
    {
        buttonRestart.onClick.AddListener(Level1SceneLoad);
        buttonPause.onClick.AddListener(enableOptionPanel);
        buttonCancel.onClick.AddListener(disableOptionPanel);
    }

    private void disableOptionPanel()
    {
        optionsPanel.SetActive(false);
    }

    private void enableOptionPanel()
    {
        optionsPanel.SetActive(true);
    }
    private void Level1SceneLoad()
    {
        SceneManager.LoadScene("Showcase");
    }
    public void deadSceneLoad()
    {
        SceneManager.LoadScene("Dead");
    }

    public void Level2SceneLoad()
    {
        SceneManager.LoadScene("Two");
    }
}

