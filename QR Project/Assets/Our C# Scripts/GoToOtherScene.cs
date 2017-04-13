using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToOtherScene : MonoBehaviour {

    public void FirstScene()
    {
        SceneManager.LoadScene("FirstScene");
    }
	public void QRcodeScene()
    {
        SceneManager.LoadScene("QR-scene");
    }
	
    public void EditProfileScene()
    {
        SceneManager.LoadScene("ProfileScene");
    }
       


    public void GoBackButton()
    {
        string CurrentScene = SceneManager.GetActiveScene().name;
        if (CurrentScene == "FirstScene")
        {
            Application.Quit();
        }
        else if (CurrentScene == "QR-scene")
        {
            SceneManager.LoadScene("FirstScene");
        }
        else if (CurrentScene == "ProfileScene")
        {
            SceneManager.LoadScene("FirstScene");
        }





    }


	
}
