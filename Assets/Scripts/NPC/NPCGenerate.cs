using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NPCGenerate : MonoBehaviour
{
    [SerializeField] private Race[] raceList;
    [SerializeField] private NPC npc;
    private void Awake()
    {
        Generate();
    }
    public void Generate()
    {
        Race race = raceList[Random.Range(0,raceList.Length)];
        bool isMan = Random.Range(0, 2) == 1;
        NPC newNPC = Instantiate(npc.gameObject).GetComponent<NPC>();
        newNPC.SetNPC(isMan, race.GetHair(isMan), race.GetHead(isMan), race.GetBody(isMan), race.GetName(isMan));
    }
}
