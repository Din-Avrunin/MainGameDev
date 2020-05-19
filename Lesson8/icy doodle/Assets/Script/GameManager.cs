using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject levelCompleteUi;
    [SerializeField] GameObject levelFailUi;
    [SerializeField] float UITimer = 3f;
    [SerializeField] Transform Player;
    [SerializeField] Transform Camera;
    [SerializeField] int maxLevel=5;
    [SerializeField] float fail_Hight = 5;
    Boolean win=false;
    public IEnumerator goal()
    {
        win = true;
        levelCompleteUi.SetActive(true);
        yield return new WaitForSeconds(UITimer);
        levelCompleteUi.SetActive(false);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void Update()
    {
        if (Player.position.y + fail_Hight <= Camera.position.y && !win)
        {
            StartCoroutine( fail());
        }   
    }
    public IEnumerator fail() {
        levelFailUi.SetActive(true);
        yield return new WaitForSeconds(UITimer);
        levelFailUi.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
