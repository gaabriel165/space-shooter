using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1f);

        float posXRandom = Random.Range(-2f, 2f);

        GameObject.Instantiate(this.enemyPrefab, new Vector3(posXRandom, 6, 0), Quaternion.identity * enemyPrefab.transform.localRotation);

        StartCoroutine(Spawn());
    }
}
