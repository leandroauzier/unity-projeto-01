using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text textoNome;
    public Text textoDialog;

    public Animator animationDialog;

    //Queue é um tipo FIFO
    private Queue<string> frases;
    void Start()
    {
        frases = new Queue<string>();
    }
    //Função que executa o dialogo passado no parametro
    public void StartDialog(Dialog dialog)
    {
        animationDialog.SetBool("IsOpen", true);
        textoNome.text = dialog.nome;
        frases.Clear();

        //Percorre a lista de frases
        foreach (string frase in dialog.frases)
        {
            //Enfileira a frase atual
            frases.Enqueue(frase);
        }
        //Mostrar a proxima frase
        DisplayNextFrase();
    }

    public void DisplayNextFrase()
    {
        if(frases.Count == 0)
        {
            EndDialog();    
            return;
        }

        string frase = frases.Dequeue();
        // caso o player queria pular pra outro texto enquanto o atual ainda está sendo animado, ele para primeiro
        StopAllCoroutines();
        //Inicia o efeito de escrever o texto na tela com a função de IEnumarator
        StartCoroutine(TypeFrase(frase));
    }

    IEnumerator TypeFrase (string frase)
    {
        textoDialog.text = "";
        //ToCharArray, converte um tipo string em um Array do tipo char:
        foreach (char letra in frase.ToCharArray())
        {
            //adiciona letra por letra
            textoDialog.text += letra;
            yield return new WaitForSeconds(0.02f);
        }
    }
    void EndDialog()
    {
        animationDialog.SetBool("IsOpen", false);
    }
}
