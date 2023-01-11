using UnityEngine;

[CreateAssetMenu(fileName = "Suspect Data", menuName = "Create Suspect Data")]
public class Suspect : ScriptableObject
{
    public enum Attributes
    {
        shy, timid, pacifist, graduate, senior, junior, sophmore, dropout, stuckUp,
        snobby, entitled, homebody, quiet, introvert, leader, friendly, helpful,
        poor, rich, arrogant, partier, troublemaker
    }

    public string sName, sAlias;

    [Range(1, 100)] public int age;

    public Attributes[] attributes;

    [TextArea(minLines: 5, maxLines: 5)] public string crimeRelation;
}