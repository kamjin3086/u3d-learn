using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{

    public GameObject restartButton;

public GameObject winTextObject;

public float speed = 0;

public TextMeshProUGUI countText;

private int count;

    private Rigidbody rb;

    private float movementX;
    private float movementY;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        winTextObject.SetActive(false);
        restartButton.SetActive(false);
    }

    void FixedUpdate(){
        Vector3 moveDirection = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(moveDirection * speed);
    }

    void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>();
        movementX = moveInput.x;
        movementY = moveInput.y;
        
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Pickup")){
                 other.gameObject.SetActive(false);
                 count = count + 1;
                 SetCountText();
        }       
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Enemy")){
            Destroy(gameObject);
            winTextObject.SetActive(false);
            countText.text = "You Lose! Count: " + count.ToString();

            restartButton.SetActive(true);
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count >= 12){
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));

            winTextObject.SetActive(true);
            
            restartButton.SetActive(true);
        }
    }
}
