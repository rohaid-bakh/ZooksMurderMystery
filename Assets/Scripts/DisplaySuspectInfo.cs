using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Assertions;

public class DisplaySuspectInfo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText, ageText, attributesText, crText;

    private void Awake() {
        Assert.IsNotNull(nameText,$"The name text field is empty. Please fill");
        Assert.IsNotNull(ageText,$"The age text field is empty. Please fill");
        Assert.IsNotNull(attributesText,$"The attributes text field is empty. Please fill");
        Assert.IsNotNull(crText,$"The crtext field is empty. Please fill");
    }

    public void DisplayInfo(Suspect suspectSO){
        nameText.text = "Name: " + suspectSO.name + "\nAlias: " + suspectSO.sAlias;
        ageText.text = "Age: " + suspectSO.age;
        attributesText.text = "Attributes: \n" + FormatAttributes(suspectSO.attributes);
        crText.text = "Crime Relationship: \n" + suspectSO.crimeRelation;
    }

    private string FormatAttributes(Suspect.Attributes[] attributes)
    {
        string formattedText = null;
        for (int i = 0; i < attributes.Length; i++)
        {
            formattedText += "\u2022  " + attributes[i] + "\n";
        }
        return formattedText;
    }

    public void ClearInfo(){
        nameText.text = "Name: " + "\nAlias: ";
        ageText.text = "Age: "; 
        attributesText.text = "Attributes: ";
        crText.text = "Crime Relationship: ";
    }
}