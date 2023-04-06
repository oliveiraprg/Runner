using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRG; // Corpo do player
    public float jumpForce = 10f; // For�a do Pulo
    public float gravityModifier = 1f; // Gravidade do jogo
    public bool isonGround = true; // Verifica se o player esta no ch�o

    // Start is called before the first frame update
    void Start()
    {
        playerRG = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isonGround)
        {
            playerRG.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isonGround = false;
        }        
    }

    private void OnCollisionEnter(Collision collision)
    {
        isonGround = true;
    }
}
