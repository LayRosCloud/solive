using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "SubtletiesRace", menuName = "ScriptableObjects/SubtletiesRaceCreate", order = 1)]
public class SubtletiesRace : ScriptableObject
{
    [SerializeField] private Sprite[] Hairs;
    [SerializeField] private Sprite[] Heads;
    [SerializeField] private Sprite[] Bodys;
    [SerializeField] private string[] Names;

    public Sprite GetHair() { return Hairs[Random.Range(0,Hairs.Length)]; }
    public Sprite GetHead() { return Heads[Random.Range(0, Heads.Length)]; }
    public Sprite GetBody() { return Bodys[Random.Range(0, Bodys.Length)]; }
    public string GetName() { return Names[Random.Range(0, Names.Length)]; }
}
