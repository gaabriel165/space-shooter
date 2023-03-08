using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroud : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime * -1);

        if(transform.position.y <= -10.23f){
            transform.position = new Vector3(0, 10.42f, 0);
        }
    }
}
