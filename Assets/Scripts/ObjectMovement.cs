using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime * -1);

        if(transform.position.y <= -15){
            Destroy(gameObject);
        }
    }
}
