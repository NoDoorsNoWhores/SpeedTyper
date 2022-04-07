using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressESCtoGoToDifferentScene : MonoBehaviour
{
    [SerializeField] private string sceneName;
    public static bool escHasOverlay = false;

    void Update()
    {
        if (!escHasOverlay && Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene(sceneName);
    }
}