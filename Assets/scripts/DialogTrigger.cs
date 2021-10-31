using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    // Aqui ele importa a classe para aparecer quando inserir esse codigo em um objeto trigger
    public Dialog dialog;
    //Função que ativa o dialogo no DialogManager
    public void TriggerDialog()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }
}
