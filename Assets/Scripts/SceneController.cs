using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public Button buttonPause, buttonRestart, buttonCancel;
    public GameObject optionsPanel;
    public GameObject deadPanel;
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
        SceneManager.LoadScene("One");
    }
    public void deadPanelLoad()
    {
        deadPanel.SetActive(true);
    }

    public void Level2SceneLoad()
    {
        SceneManager.LoadScene("Two");
    }
}

