using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ourScript : MonoBehaviour
{
    private TextMeshPro textMesh;
    [Tooltip("number of lives")] [SerializeField] int numOfLives;
    public static int shem;
    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshPro>();
        shem = numOfLives;
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = shem.ToString();
    }
}
