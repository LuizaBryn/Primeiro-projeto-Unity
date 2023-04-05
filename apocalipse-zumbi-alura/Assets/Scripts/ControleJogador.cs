using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogador : MonoBehaviour
{

    public float Velocidade = 10;
    Vector3 direcao;

    void Update()
    {
        //Inputs do Jogador - Guardando teclas apertadas
        float eixoX = Input.GetAxis("Horizontal");
        float eixoZ = Input.GetAxis("Vertical");

        direcao = new Vector3(eixoX, 0, eixoZ);


        //Anima��es do Jogador
        if (direcao != Vector3.zero)
        {
            GetComponent<Animator>().SetBool("movendo", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("movendo", false);
        }
    }

    void FixedUpdate()
    {
        //Movimenta��o do Jogador por segundo
        GetComponent<Rigidbody>().MovePosition
            (GetComponent<Rigidbody>().position +
            (direcao * Velocidade * Time.deltaTime));
    }
}