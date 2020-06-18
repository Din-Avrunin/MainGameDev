using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{
    Text Text;
    // Start is called before the first frame update
    void Start()
    {
        Text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = "Level " + (SceneManager.GetActiveScene().buildIndex-2);
    }
}
