using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class main_controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void switchSongList() {
        SceneManager.LoadScene(1);
    }

    public void switchSetting() {
        SceneManager.LoadScene(2);
    }

    public void quitGame(){
        Application.Quit();
    }


}
