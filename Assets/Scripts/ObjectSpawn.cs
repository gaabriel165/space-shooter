using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    [SerializeField] GameObject starsPrefab;
    [SerializeField] GameObject planetsPrefab;
    [SerializeField] GameObject meteorsPrefab;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(4f);

        GameObject[] objects = { planetsPrefab, meteorsPrefab };

        int index = Random.Range(0, objects.Length);

        GameObject.Instantiate(objects[index], new Vector3(0, 15, 0), Quaternion.identity);

        StartCoroutine(Spawn());
    }
}
