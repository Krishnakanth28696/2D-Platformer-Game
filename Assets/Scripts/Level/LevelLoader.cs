using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class LevelLoader : MonoBehaviour
{
    private Button button;
    public String LevelName;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(PickUp);
    }

    private void PickUp()
    {
        SceneManager.LoadScene(LevelName);
    }
}
