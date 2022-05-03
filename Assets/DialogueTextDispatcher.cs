using TMPro;
using UnityEngine;

public class DialogueTextDispatcher : MonoBehaviour
{
    private TMP_Text text;
    
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    void UpdateText(string value)
    {
        text.text = value;
    }
}
