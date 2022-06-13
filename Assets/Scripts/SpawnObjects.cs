using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject collectablePrefab;
    public float respawnTime = 1.0f;
    private float screenLimit = 4.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyWave());
    }

    private void SpawnEnemy(){
        GameObject newEnemy = Instantiate(enemyPrefab) as GameObject;
        newEnemy.transform.position = new Vector2(8f, Random.Range(-screenLimit, screenLimit));
    }
    IEnumerator EnemyWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            SpawnEnemy();
        }
        
    }
}
