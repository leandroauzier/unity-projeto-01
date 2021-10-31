using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// para ser visto no editor
[System.Serializable]
// A classe não deriva do monobehaviour pois não é necessário partir de outro script visto que esse será
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

//OBS: para que apareça de fato no editor e seja capaz de editar, é necessário criar outro script trigger
//importando esse codigo.
