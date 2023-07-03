using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] private TMP_Text Name;
    [SerializeField] private SpriteRenderer Hair;
    [SerializeField] private SpriteRenderer Head;
    [SerializeField] private SpriteRenderer Body;
    [SerializeField] private bool isMan;
    public void SetNPC(bool isMan, Sprite Hair, Sprite Head, Sprite Body, string Name)
    {
        this.isMan = isMan;
        this.Hair.sprite = Hair;
        this.Head.sprite = Head;
        this.Body.sprite = Body;
        this.Name.text = Name;
    }
}
