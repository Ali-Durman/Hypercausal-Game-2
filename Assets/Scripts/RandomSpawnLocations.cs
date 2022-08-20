using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnLocations : MonoBehaviour
{
    public GameObject theEnemy;
    public float xPos;
    public float zPos;
    public int enemyCount;
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }
    IEnumerator EnemySpawn()
    {
        while(enemyCount < 25)
        {
            xPos = Random.Range(-5, 5);
            zPos = Random.Range(-21, 26);
            Instantiate(theEnemy, new Vector3(xPos, 0.5f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }
    }
}
