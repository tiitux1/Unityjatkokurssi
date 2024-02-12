


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float speed;
    public float jumpForce = 400f;
    public float rotationTorque = 100f;
    Rigidbody2D rb;
   
    Vector2 playerInput;
    Vector3 respawnPoint;


    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position;
        Debug.Log("Pelaaja hahmo on luotu");
    }


    void Update()
    {


        playerInput.x = Input.GetAxis("Horizontal") * speed;
        playerInput.y = rb.velocity.y;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rb.velocity.y > -0.05f && rb.velocity.y < 0.05f)
            {
                Debug.Log("pelaaja hypp�si");
                Jump(); // Kutsutaan Jump-metodia, kun pelaaja painaa hyppyn�pp�int�
            }
        }
    }

    private void FixedUpdate()
    {

        rb.velocity = playerInput;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Death")
        {
            SceneManager.LoadScene(0);
        }
    }

    public void Respawn()
    {
        transform.position = respawnPoint;

    }

    void Jump()
    {
        // Lis�t��n voima yl�sp�in hypyn suorittamiseksi
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        // Lis�t��n py�r�hdysvoima hypyn aikana
        rb.AddTorque(rotationTorque, ForceMode2D.Impulse);
    }


}
