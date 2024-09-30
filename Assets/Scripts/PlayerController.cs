using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
 private Rigidbody rb; 
private int score;
 private float movementX, movementY;
 
 public float speed = 0; 
 
 public TextMeshProUGUI scoreText;
 public GameObject victoryText;
 public GameObject SplashScreenCanvas;
 void Start()
    {

        rb = GetComponent<Rigidbody>();
        score = 0;
        victoryText.SetActive(false);
        SplashScreenCanvas.SetActive(true);
    }

 void Update(){
    if(Input.GetKeyDown(KeyCode.Space)){
        SplashScreenCanvas.SetActive(false);
    }
 }
 
 void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x; 
        movementY = movementVector.y; 
    }

 private void FixedUpdate() 
    {
        Vector3 movement = new Vector3 (movementX, 0.0f, movementY);

        rb.AddForce(movement * speed); 
    }

 void OnTriggerEnter(Collider other){
    
    if(other.gameObject.CompareTag("Pickup")){

        other.gameObject.SetActive(false);
        score += 1;
        scoreText.text = "Score: " + score.ToString();
        if(score >= 45 ){
            victoryText.SetActive(true);
        }
    }

    
 }
}
