using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]

public class MenuUIHandler1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
       NewTextSelected(MainManagerMenu.Instance.textoDeNota);
    }
    

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
      MainManagerMenu.Instance.SaveText(); 
       MainManagerMenu.Instance.SaveText(); 
       #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
       #else
        Application.Quit(); // original code to quit Unity player
       #endif

       
    }

    public void NewTextSelected(Text t){
        MainManagerMenu.Instance.textoDeNota = t;
    }

    

}
