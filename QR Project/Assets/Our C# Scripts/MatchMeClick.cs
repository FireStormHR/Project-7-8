using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MatchMeClick : MonoBehaviour {

    public void OnClick()
    {
        //DO A LOT

        GoToOtherScene SceneNavigator = new GoToOtherScene();
        SceneNavigator.QRcodeScene();

    }


}
