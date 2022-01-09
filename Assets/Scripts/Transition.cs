using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;     
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadNextLevel();
        }
    }
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator LoadLevel(int levelindex)
    {
        transition.SetTrigger("Start");
         
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelindex);    
    }
} 