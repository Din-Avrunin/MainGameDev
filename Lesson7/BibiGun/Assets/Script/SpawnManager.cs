using System;
using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    public float time = 4f;
    [SerializeField]
    private GameObject _enemyPrefabs;
    [SerializeField]
    private GameObject _enemyContainer;
    [SerializeField]
    private GameObject _powerUpPrefabs;
    [SerializeField]
    private float positive = 8f;
    [SerializeField]
    private float negative = -8f;

    // Start is called before the first frame update 
    void Start()
    {
        StartCoroutine("SpawnEnemyRoutine");
        StartCoroutine(SpawnPowerUpRoutine());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnPowerUpRoutine()
    {
        while (true)
        {
            Vector3 postospawn = new Vector3(UnityEngine.Random.Range(negative, positive), 13, 0);
            GameObject new_powerUp = Instantiate(_powerUpPrefabs, postospawn, Quaternion.identity);
            yield return new WaitForSeconds(UnityEngine.Random.Range(10, 15));
        }
    }

    IEnumerator SpawnEnemyRoutine()
    {
        while (true)
        {

            Vector3 postospawn = new Vector3(UnityEngine.Random.Range(negative, positive), 13, 0);
            GameObject new_enemy = Instantiate(_enemyPrefabs, postospawn, Quaternion.identity);
            new_enemy.transform.parent = _enemyContainer.transform;
            //if (time.time % 10 == 0)
            //{
            //    time /= 2;


            //}
            yield return new WaitForSeconds(time);
        }
    }


}
