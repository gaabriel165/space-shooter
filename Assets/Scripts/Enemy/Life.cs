using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{

    [SerializeField] private Animator enemyAnimator;

    public float life = 100;
    private bool dead = false;

    void Update()
    {
        if(this.life <= 0 && this.dead == false){
            this.dead = true;
            this.GetComponent<BoxCollider2D>().enabled = false;
            this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            enemyAnimator.Play("enemy-explosion");
        }
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.tag == "Bullet"){
            System.Random random = new System.Random();

            float damage = Mathf.RoundToInt(random.Next(20, 30));

            this.life -= damage;
        }
    }
}
