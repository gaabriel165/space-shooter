using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpawn : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(2f);

        GameObject.Instantiate(this.bulletPrefab, this.transform.position, Quaternion.identity);

        StartCoroutine(Spawn());
    }
}
