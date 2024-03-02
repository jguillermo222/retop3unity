using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unit1 : MonoBehaviour
{
    public Text yourText;
   

    // Start is called before the first frame update
    void Start()
    {

        if (MainManagerMenu.Instance != null)
    {
        SetTexto(MainManagerMenu.Instance.textoDeNota);
        
    }

    // Update is called once per frame
  

    void SetTexto(Text t)
    {
      yourText.text = t.text;
    }
      
}
}