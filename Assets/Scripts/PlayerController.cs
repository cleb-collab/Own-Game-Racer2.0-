using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public float turnSpeed = 50;
    public float horizontalInput;
    private float verticalInput;
    public bool gameOver;
    public int health = 3;
  
   

    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Lives " + health);
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // Moves the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        // Turns the car on the Y axis
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }
    private void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("Enemy"))
		{
			Destroy(other.gameObject);
            gameOver = true;
			Debug.Log("Game Over!");
		}
        if (other.gameObject.CompareTag("Enemy"))
        {
            if (health < 1)
            {
                health = 0;
                Debug.Log("Game Over!");
            }else
            {
                health -= 1;
                Destroy(other.gameObject);
                Debug.Log("Lives " + health);
            }
               
        }
    }
}
