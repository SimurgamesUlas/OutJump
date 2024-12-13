using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private GameManager gm;
    void Update()
    {
        if(gm.isStart == true && gm.isDead == false){
             transform.Translate(0f,moveSpeed * Time.deltaTime,0f);
        }
       
    }
}
