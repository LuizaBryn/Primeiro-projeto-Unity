using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaJogador : MonoBehaviour
{

    public float Velocidade = 10;

    void Update()
    {
       //Inputs do Jogador - Guardando teclas apertadas

          float eixoX = Input.GetAxis("Horizontal");
          float eixoZ = Input.GetAxis("Vertical");

          Vector3 direcao = new Vector3(eixoX, 0, eixoZ);

          transform.Translate(direcao * Velocidade * Time.deltaTime);
        

        //Animações do Jogador
        if (direcao != Vector3.zero)
        {
            GetComponent<Animator>().SetBool("movendo", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("movendo", false);
        }
    }

}