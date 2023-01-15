using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class VerdictValidator : MonoBehaviour
{
    private string selectedSuspect;
    [SerializeField] private GuiltySuspect correctSuspect;

    public void Awake(){
        Assert.IsNotNull(correctSuspect, "The guilty suspect has not been set. Please do so.");
    }
    public void setSelectedSuspect(string suspect){
        selectedSuspect = suspect;
    }
    
    public void checkVerdict(){
        if(selectedSuspect.Equals(correctSuspect.correctSuspectName)){
            Debug.Log("Congrats! You figured it out");
        } else {
            Debug.Log("You have sentenced an innocent person. Try again");
        }
    }

}
