using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC1 : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Text dialoguetext;
    public string[] dialogue;
    private int index;
    public float wordSpeed;
    public bool playerIsClose;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)&& playerIsClose){
            if(dialoguePanel.activeInHierarchy){
                zeroText();


            }
            else{
                dialoguePanel.SetActive(true);
                StartCorouting (Typing());
            }
        }
        
    }

    public void zeroText(){
        dialoguetext.text="";
        index = 0;
        dialoguePanel.SetActive(false);

    }

    IEnumerator Typing(){
        foreach(char letter in dialogue[index].ToCharArray()){
            dialoguetext.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine(){
        if(index < dialogue.length-1){
            index++;
            dialoguetext.text ="";
            StartCorouting (Typing());
        }
        else{
            zeroText();
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Playetr")){
            playerIsClose = true;
        }
    }
    private void OnTriggerExitr2D(Collider2D other){
        if(other.CompareTag("Playetr")){
            playerIsClose = false;
            zeroText();
        }
    }
}
