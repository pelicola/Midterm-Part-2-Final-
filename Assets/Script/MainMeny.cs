using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement;

public class MainMeny : MonoBehaviour
{
        public GameObject mainmenu;  
        public GameObject restart; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart(){ 
        SceneManager.LoadScene("SampleScene");
    }

    public void PlayGame(){
        mainmenu.gameObject.SetActive(false);
        restart.gameObject.SetActive(true); 


    }
}
