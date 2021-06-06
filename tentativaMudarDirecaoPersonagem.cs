using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private Rigidbody2D rb2D;
    private bool eLadoDireito;

    // Variavel
    float horizontal; 

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        eLadoDireito = transform.localScale.x > 0;        
    } 

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");

        MudarDirecao(horizontal);
    }



    private void MudarDirecao(float horizontal)
    {
        if(horizontal > 0 && !eLadoDireito || horizontal < 0 && eLadoDireito)
        {
            eLadoDireito = !eLadoDireito;
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
    }
}
