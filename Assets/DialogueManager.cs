using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    private GameObject _dialogueManagerGO;
    private GameObject _dialogueTextDispatcherGO;

    /// <summary>
    /// Loads the game objects
    /// </summary>
    void Start()
    {
        _dialogueManagerGO = FindObjectOfType<DialogueManager>().gameObject;
        _dialogueTextDispatcherGO = FindObjectOfType<DialogueTextDispatcher>().gameObject;
    }

    /// <summary>
    /// Shows the dialogue pop-up game object
    /// </summary>
    void ShowDialogue()
    {
        
    }

    /// <summary>
    /// Start reading first dialogue (front of queue)
    /// </summary>
    void StartDialogueSequence()
    {
        
        // DialogueSequence.Next();
    }
}
