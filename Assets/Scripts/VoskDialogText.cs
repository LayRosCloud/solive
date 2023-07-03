using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using TMPro;

public class VoskDialogText : MonoBehaviour 
{
    public VoskSpeechToText VoskSpeechToText;
    public TMP_Text DialogText;
    void Awake()
    {
        VoskSpeechToText.OnTranscriptionResult += OnTranscriptionResult;
    }
    private void OnTranscriptionResult(string obj)
    {
        var result = new RecognitionResult(obj);
        foreach (RecognizedPhrase p in result.Phrases)
        {
            DialogText.text += p.Text;
            if (p.Text.Contains("блок"))
            {
                DialogText.text += 1;
                if (p.Text.Contains("чинить"))
                {
                    DialogText.text += 2;
                }
            }
        }
    }
}
