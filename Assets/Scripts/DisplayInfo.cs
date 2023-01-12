using UnityEngine;
using UnityEngine.UI;

public class DisplayInfo : MonoBehaviour
{

    [SerializeField] private Suspect suspect;

    [SerializeField] private Canvas canvas;

    [SerializeField] private Button closeButton;

    [SerializeField] private Text nameText, ageText, attributesText, crText;

    private void OnMouseDown()
    {
        canvas.enabled = true;
        print("Working");
        nameText.text = "Name: " + suspect.name + "\nAlias: " + suspect.sAlias;
        ageText.text = "Age: " + suspect.age.ToString();
        attributesText.text = "Attributes: \n" + returnAttFormat(suspect.attributes);
        crText.text = "Crime Relationship: " + suspect.crimeRelation;
    }

    private string returnAttFormat(Suspect.Attributes[] attributes)
    {
        string formattedText = null;
        for (int i = 0; i < attributes.Length; i++)
        {
            formattedText += "\u2022  " + attributes[i].ToString() + "\n";
        }
        return formattedText;
    }

    public void CloseNote()
    {
        canvas.enabled = false;
    }
}