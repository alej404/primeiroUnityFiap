using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Personagem : MonoBehaviour
{
    Rigidbody2D personagem;
    int velocidade;
    int pulo;
    bool pulando;

    // Start is called before the first frame update
    void Start()
    {
        personagem = GetComponent<Rigidbody2D>();
        pulando = true;
        velocidade = 3;
        pulo = 12;
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
        Pular();
    }

    void Mover()
    {
        if(Input.GetKey("right"))
        {
            personagem.velocity = new Vector2(velocidade, personagem.velocity.y);
        }
        else if(Input.GetKey("left"))
        {
            personagem.velocity = new Vector2(-velocidade, personagem.velocity.y);
        }
    }

    void Pular()
    {
        if(Input.GetKey("up") && !pulando)
        {
            personagem.velocity = new Vector2(personagem.velocity.x, pulo);
            pulando = true;
        }
    }

    void OnCollisionEnter2D(Collision2D pisando)
    {
        if(pisando.gameObject.tag == "Plataforma")
        {
            pulando = false;
        }
        if(pisando.gameObject.tag == "Armadilha")
        {
            SceneManager.LoadScene("Jogo");
        }
    }
}
