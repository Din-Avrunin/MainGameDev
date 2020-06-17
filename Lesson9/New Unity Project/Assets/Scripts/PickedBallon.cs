using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickedBallon : MonoBehaviour
{
    [SerializeField] GameObject text;

    private void Start()
    {
        PlayerPrefs.SetInt("activeShield", 0);
    }
    // Start is called before the first frame update
    public void SetBallonColor(int colorId)
    {
        text.SetActive(false);
        if (PlayerPrefs.GetInt("activeShield") == 0)
        {
            if (colorId == 5)
            {
                if (GameObject.Find("GameManager").GetComponent<GameManager>().buyRequest())
                {
                    PlayerPrefs.SetInt("activeShield", 1);
                    PlayerPrefs.SetInt("color", colorId);
                }
                else
                {
                    text.SetActive(true);
                }
            }
            else
            {

                PlayerPrefs.SetInt("color", colorId);
                PlayerPrefs.SetInt("prevcolor", colorId);
            }
        }
    }
}
