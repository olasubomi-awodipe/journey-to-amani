/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC1 : MonoBehaviour
{
    public GameObject dialoguePanel;
    public GameObject contButton;
    public Text dialoguetext; // Ensuring the variable name matches the UI element
    public string[] dialogue;
    private int index;
    public float wordSpeed;
    public bool playerIsClose;

    void Start()
    {
        // Optionally initialize any variables if needed
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            if (dialoguePanel.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }
        if (dialoguetext.text == dialogue[index]){
            contButton.SetActive(true);
        }
    }

    public void zeroText()
    {
        dialoguetext.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialoguetext.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {

        contButton.SetActive(false);
        if (index < dialogue.Length - 1)
        {
            index++;
            dialoguetext.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            zeroText();
        }
    }
}
*/
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Import the TextMesh Pro namespace

public class NPC1 : MonoBehaviour
{
    public GameObject dialoguePanel;
    public GameObject contButton;
    public TMP_Text dialoguetext; // Change Text to TMP_Text
    public string[] dialogue;
    private int index;
    public float wordSpeed;
    public bool playerIsClose;

    void Start()
    {
        dialoguePanel.SetActive(false);
        contButton.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            if (dialoguePanel.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }
        
        if (dialoguetext.text == dialogue[index])
        {
            contButton.SetActive(true);
        }
    }

    public void zeroText()
    {
        dialoguetext.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
        contButton.SetActive(false);
    }

    IEnumerator Typing()
    {
        contButton.SetActive(false);
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialoguetext.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {
        contButton.SetActive(false);
        if (index < dialogue.Length - 1)
        {
            index++;
            dialoguetext.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered trigger");
            playerIsClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player exited trigger");
            playerIsClose = false;
            zeroText();
        }
    }
}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Import the TextMesh Pro namespace

public class NPC1 : MonoBehaviour
{
    public GameObject dialoguePanel;
    public GameObject contButton;
    public TMP_Text dialoguetext; // Change Text to TMP_Text
    public string[] dialogue;
    private int index;
    public float wordSpeed;
    public bool playerIsClose;

    void Start()
    {
        dialoguePanel.SetActive(false);
        contButton.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            if (dialoguePanel.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }
        
        if (dialoguetext.text == dialogue[index])
        {
            contButton.SetActive(true);
        }
    }

    public void zeroText()
    {
        dialoguetext.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
        contButton.SetActive(false);
    }

    IEnumerator Typing()
    {
        contButton.SetActive(false);
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialoguetext.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {
        contButton.SetActive(false);
        if (index < dialogue.Length - 1) // Corrected from dialogue.length to dialogue.Length
        {
            index++;
            dialoguetext.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered trigger");
            playerIsClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player exited trigger");
            playerIsClose = false;
            zeroText();
        }
    }
}
