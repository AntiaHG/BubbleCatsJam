using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject collectablePrefab10;
    public GameObject collectablePrefab20;
    private float screenLimit = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyWave());
        StartCoroutine(CollectableWave10());
        StartCoroutine(CollectableWave20());
    }

//Enemigos
    private void SpawnEnemy(){
        GameObject newEnemy = Instantiate(enemyPrefab) as GameObject;
        newEnemy.transform.position = new Vector2(8f, Random.Range(-screenLimit, screenLimit));
    }
    IEnumerator EnemyWave(){
        while(true){
            yield return new WaitForSeconds(1f);
            SpawnEnemy();
        }
    }

//Coleccionables
    private void SpawnCollectable10(){
        GameObject newCollectable10 = Instantiate(collectablePrefab10) as GameObject;
        newCollectable10.transform.position = new Vector2(8f, Random.Range(-screenLimit, screenLimit));
    }
    IEnumerator CollectableWave10(){
         while(true){
            yield return new WaitForSeconds(1.5f);
            SpawnCollectable10();
        }
    }
    private void SpawnCollectable20(){
        GameObject newCollectable20 = Instantiate(collectablePrefab20) as GameObject;
        newCollectable20.transform.position = new Vector2(8f, Random.Range(-screenLimit, screenLimit));
    }

    IEnumerator CollectableWave20(){
        while(true){
            yield return new WaitForSeconds(4f);
            SpawnCollectable20();
        }
    }
}
