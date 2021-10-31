using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// para ser visto no editor
[System.Serializable]
// A classe n�o deriva do monobehaviour pois n�o � necess�rio partir de outro script visto que esse ser�
// o Maintainer principal.
public class Dialog
{
    // Nome do NPC que fala
    public string nome;
    // Mudando a lista de string para ser um Textarea com min 3 linhas e max 10
    [TextArea(3,10)]
    // Carrega as frases no Queue
    public string[] frases;
}

//OBS: para que apare�a de fato no editor e seja capaz de editar, � necess�rio criar outro script trigger
//importando esse codigo.
