using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Animator bulletAnimator;
    private bool destroyed = false;

    void Update()
    {
        if(this.destroyed == false){
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        if(transform.position.y >= 5.2){
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Enemy" && destroyed == false){
            this.destroyed = true;
            bulletAnimator.Play("bullet-explosion");
        }
    }
}
