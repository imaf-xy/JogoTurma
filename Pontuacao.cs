using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Pontuacao : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void OnMouseDown()
    {
        float pontuacao = transform.position.y - GameObject.Find("Barra").transform.position.y ;
        

        Debug.Log(Math.Round(100 - (pontuacao * 10),0));


    }


}
