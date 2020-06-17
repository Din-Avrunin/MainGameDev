using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickedBallon : MonoBehaviour
{

    private void Start()
    {
    }
    // Start is called before the first frame update
    public void SetBallonColor(int colorId)
    {
        PlayerPrefs.SetInt("color", colorId);
    }
}
