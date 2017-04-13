using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndroidBackButton : MonoBehaviour {
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            GoToOtherScene SceneNavigator = new GoToOtherScene();
            SceneNavigator.GoBackButton();
        }
    }


}
