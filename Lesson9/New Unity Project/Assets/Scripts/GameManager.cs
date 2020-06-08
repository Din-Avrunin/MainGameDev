using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject levelFailUi;
    // Start is called before the first frame update
    public void fail()
    {
        levelFailUi.SetActive(true);
    }
    public void win() {
        SceneManager.LoadScene(2);
    }
}
