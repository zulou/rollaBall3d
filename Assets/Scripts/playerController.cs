using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System;

public class playerController : MonoBehaviour {

    public float speed = 800.0f;
    public Text scoreText;
    private int count=0;
    public Text wintext;
    // Use this for initialization
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }

     void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Pick"){
            other.gameObject.SetActive(false);
            count+=1;
            scoreText.text="Score:"+count;

            if(count==3){
                wintext.gameObject.SetActive(true);
                scoreText.gameObject.SetActive(false);
            }
            
        }
    }

}
