using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCinteract : MonoBehaviour    
{
    public int number_ID;
    bool IsTalkable = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        while (collision.CompareTag("player"))
        {
            IsTalkable = true;
        }
    }
}
