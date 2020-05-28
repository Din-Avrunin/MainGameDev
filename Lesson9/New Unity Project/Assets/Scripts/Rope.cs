using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    [SerializeField] GameObject Baloon;
    [SerializeField] GameObject Player;
    [SerializeField] float offsetx;
    [SerializeField] float offsety;

    private LineRenderer line;                           // Line Renderer

    // Use this for initialization
    void Start()
    {
        // Add a Line Renderer to the GameObject
        line = this.gameObject.AddComponent<LineRenderer>();
        // Set the width of the Line Renderer
        line.SetWidth(0.05F, 0.05F);
        // Set the number of vertex fo the Line Renderer
        line.SetVertexCount(2);
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the GameObjects are not null
        if (Baloon != null && Player != null)
        {
            // Update position of the two vertex of the Line Renderer
            line.SetColors(Color.black,Color.black);
            Vector3 vec = Baloon.transform.position;
            vec.z += .5f;
            line.SetPosition(0, vec);
           vec = Player.transform.position;
           vec.x +=offsetx;
            vec.y += offsety;
            vec.z = -0.5f;
            line.SetPosition(1, vec);
        }
    }

}
