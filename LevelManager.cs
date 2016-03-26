using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string name)
    {
        Debug.Log("Level load requeste for: "+name);
        SceneManager.LoadScene(name);
        //Application.LoadLevel(name); 
    }//end LoadLevel

    public void QuitRequest()
    {
        Debug.Log("Quit requested for: "+name);
    }//end QuitRequest
}
