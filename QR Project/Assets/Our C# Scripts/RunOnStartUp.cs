using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunOnStartUp : MonoBehaviour {

    [InitializeOnLoad]
    public class Startup
    {
        static Startup()
        {
            //Application.LoadLevel("FirstScene");
            SceneManager.LoadScene("FirstScene");
        }
    }
}
