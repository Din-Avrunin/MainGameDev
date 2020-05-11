using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cow : MonoBehaviour
{
    [SerializeField]
    private float m_Speed=0.4f;
    private GameObject _explosion;



    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine("Turn");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.down * 4f * Time.deltaTime);
        transform.position += new Vector3(0, -1f * Time.unscaledDeltaTime, 0);
        transform.Rotate(Vector3.forward * m_Speed);

        //transform.Rotate(new Vector3(0, 0, 1) * m_Speed * Time.deltaTime);

        if (transform.position.y < -5.7f)
        {
            Destroy(this.gameObject);
        }
    }

   /* IEnumerator Turn()
    {
        int side = Random.Range(0, 1);
        if (side == 0) side = -1;
        while (true)
        {
            
            transform.rot
            transform.Rotate(transform.rotation.x, transform.rotation.y, transform.rotation.z + side);
            yield return new WaitForSeconds(1);
        }
    }*/
}
