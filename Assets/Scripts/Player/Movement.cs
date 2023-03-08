using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour{

    private Vector3 touchPosition;
    private Rigidbody2D rb;
    private Vector3 direction;
    private float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0);
        this.transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0);

        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y) * speed;

            if(touch.phase == TouchPhase.Ended){
                rb.velocity = Vector2.zero;
            }
        }
    }
}
