using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud_manager : MonoBehaviour
{
    [SerializeField]
    private GameObject _cloud;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnRoutine");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {

            Vector3 postospawn = new Vector3(Random.Range(-8f, 8f), 12f, 0);
           // Vector3 postospawn = new Vector3(17.2f, Random.Range(-6f, 8f), 0);
            GameObject new_cloud = Instantiate(_cloud, postospawn, Quaternion.identity);
            new_cloud.transform.parent = transform;
            int time = Random.Range(20, 30);
            if (time <22)
            {
                time = 1;
            }
            yield return new WaitForSeconds(time);
        }
    }

}
