using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public float time = 4f;
    [SerializeField]
    private GameObject _enemyPrefabs;
    [SerializeField]
    private GameObject _enemyContainer;
    [SerializeField]
    private float up = 8f;
    [SerializeField]
    private float x = 0f;
    [SerializeField]
    private float down = -8f;

    // Start is called before the first frame update 
    void Start()
    {
        StartCoroutine("SpawnEnemyRoutine");
    }


    IEnumerator SpawnEnemyRoutine()
    {
        while (true)
        {

            Vector3 postospawn = new Vector3(x, UnityEngine.Random.Range(up, down), 0);
            GameObject new_enemy = Instantiate(_enemyPrefabs, postospawn, _enemyPrefabs.gameObject.transform.rotation);
            new_enemy.transform.parent = _enemyContainer.transform;
            //if (time.time % 10 == 0)
            //{
            //    time /= 2;


            //}
            yield return new WaitForSeconds(time);
        }
    }
}