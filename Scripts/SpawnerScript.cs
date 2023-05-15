using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnerScript : MonoBehaviour
{
    public GameObject BombPrefab;
    private float minX = -1.82f;
    private float maxX = 1.82f;
    
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(SpawnBombs());
    }

    IEnumerator SpawnBombs()
    {
        yield return new WaitForSeconds(Random.Range(0f, 1f));
        Instantiate(BombPrefab, new Vector2(Random.Range(minX, maxX), transform.position.y), Quaternion.identity);
        StartCoroutine(SpawnBombs());
    }
}
