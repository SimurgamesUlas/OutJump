using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpPower;

    [SerializeField] private GameManager gm;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime,0f,0f);
        if(Input.GetMouseButtonDown(0) && rb.velocity.y == 0){
            rb.velocity = Vector2.up * jumpPower;
            gm.isStart = true;
        }

    }
    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Short")){
            moveSpeed *= -1;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Star")){
            gm.StarCount++;
            Destroy(other.gameObject);
        }
        if(other.gameObject.CompareTag("Flag")){
            gm.LevelUpdatPanel();
            gm.isDead = true;
        }
        if(other.gameObject.CompareTag("Ground")){
            gm.GameOver();
           
        }
    }
}
