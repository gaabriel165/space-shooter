using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float speed = 4f;
    private Rigidbody2D rb;
    private GameObject player;

    void Start(){
        this.rb = GetComponent<Rigidbody2D>();
        this.player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - this.transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * speed;

        float rot = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(rot, Vector3.forward);
    }

    void Update()
    {
        if(transform.position.x <= -3 || transform.position.x >= 3 || transform.position.y <= -5 || transform.position.y >= 6){
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            Destroy(this.gameObject);
        }
    }
}
