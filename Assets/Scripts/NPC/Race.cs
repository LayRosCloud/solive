using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Race", menuName = "ScriptableObjects/RaceCreate", order = 1)]
public class Race : ScriptableObject
{
    [SerializeField] private string Name;
    [SerializeField] private Color[] SkinColors;
    [SerializeField] private Color[] HairColors;
    [SerializeField] private SubtletiesRace SubtletiesMan;
    [SerializeField] private SubtletiesRace SubtletiesWoman;
    public Sprite GetHair(bool isMan)
    {
        return isMan ? SubtletiesMan.GetHair() : SubtletiesWoman.GetHair();
    }
    public Sprite GetHead(bool isMan)
    {
        return isMan ? SubtletiesMan.GetHead() : SubtletiesWoman.GetHead();
    }
    public Sprite GetBody(bool isMan)
    {
        return isMan ? SubtletiesMan.GetBody() : SubtletiesWoman.GetBody();
    }
    public string GetName(bool isMan)
    {
        return isMan ? SubtletiesMan.GetName() : SubtletiesWoman.GetName();
    }
    private SubtletiesRace GetSubtletiesRace(bool isMan)
    {
        return isMan ? SubtletiesMan : SubtletiesWoman;
    }
}
