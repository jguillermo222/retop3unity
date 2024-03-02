using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class MainManagerMenu : MonoBehaviour
{
    
     //paso 1 preparar el instance y el singleton
    public static MainManagerMenu Instance;
    //paso 2 
    public Text textoDeNota;
    


   

    //paso 3 que salga el texto en otro texto
     
    //saving



    private void Awake()
    {
        


      if (Instance != null)
    {
        Destroy(gameObject);
        return;
    }
    // end of new code

    Instance = this;
    DontDestroyOnLoad(gameObject);
     
     //LoadText(); 


    }










    ///parte 1 de guardado crear un savedata
    
    class SaveData
    {
        public Text textoDeNota;
    }

    //Parte2 crear un metodo save text

    public void SaveText()
    {
    SaveData data = new SaveData();
    data.textoDeNota = textoDeNota;

    string json = JsonUtility.ToJson(data);
  
    File.WriteAllText(Application.persistentDataPath + "/savefile1.json", json);
    }
    
    // creacion de un metodo llamado LoadText
    public void LoadText()
    {
        string path = Application.persistentDataPath + "/savefile1.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

        textoDeNota = data.textoDeNota;
    }
    }

    

    }
 
