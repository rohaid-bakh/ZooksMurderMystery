using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

/// <Author> Author: Rohaid </Author> 
/// <Summary>Purpose: Attached to all character buttons. Holds relevant suspect SO./// </Summary>
public class DisplaySuspectWindow : MonoBehaviour
{
    private DisplaySuspectInfo infoScript;
    [SerializeField] private Suspect suspectSO;
    private void Awake() {
        infoScript = FindObjectOfType<DisplaySuspectInfo>(true);

        Assert.IsNotNull(suspectSO, $"The suspect field of {gameObject.name} is empty");
        Assert.IsNotNull(infoScript, "The DisplaySuspectInfo script is missing from the scene. Please apply it.");
    }

    public void SendInfo(){
        infoScript.DisplayInfo(suspectSO);
    }

    public void ClearInfo(){
        infoScript.ClearInfo();
    }
}
