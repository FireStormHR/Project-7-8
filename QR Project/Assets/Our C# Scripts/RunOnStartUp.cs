using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
    using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunOnStartUp : MonoBehaviour {

    #if UNITY_EDITOR
        [InitializeOnLoad]
        public class Startup
        {
            static Startup()
            {
                //Application.LoadLevel("FirstScene");
                SceneManager.LoadScene("FirstScene");
            }
        }
    #endif

    #if UNITY_ANDROID


    #endif





}
