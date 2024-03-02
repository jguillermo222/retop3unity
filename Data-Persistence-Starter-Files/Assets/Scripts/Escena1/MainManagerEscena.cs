using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManagerEscena : MonoBehaviour
{
    public static MainManagerEscena Instance;
    // Start is called before the first frame update

    //paso 2 
    public Text textoPuntajeMax;

   


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
}

}
