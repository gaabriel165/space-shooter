using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    private Life enemy; 

    private void Start() {
        this.enemy = gameObject.GetComponent<Life>();    
    }

    void Update()
    {
        if(this.enemy.life >= 1){
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        if(transform.position.y <= -5.4){
            Destroy(this.gameObject);
        }
    }
}
