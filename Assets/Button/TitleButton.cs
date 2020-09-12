using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{

    public void OnClick()
    {
        ChangeScene();
    }
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("ChangeScene", 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
