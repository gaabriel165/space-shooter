using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{

    [SerializeField] private GameObject bulletPrefab;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(0.2f);

        GameObject.Instantiate(this.bulletPrefab, this.transform.position, Quaternion.identity);

        StartCoroutine(Spawn());
    }
}
