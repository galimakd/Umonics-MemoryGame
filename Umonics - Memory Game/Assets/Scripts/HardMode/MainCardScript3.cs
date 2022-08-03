using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCardScript3 : MonoBehaviour
{
    [SerializeField] private SceneControllerScript3 controller3;
    [SerializeField] private GameObject BackCard;
    [SerializeField] private AudioSource audioSource;

    //Change photo on click
    public void OnMouseDown() {
        if(BackCard.activeSelf && controller3.canReveal) {
            BackCard.SetActive(false);
            controller3.CardRevealed(this);
            audioSource.Play();
        }
    }

    //Randomize Front face of Card
    private int _id;
    public int id {
        get { return _id;}
    }

    public void ChangeSprite(int id, Sprite image) {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    public void Unreveal() {
        BackCard.SetActive(true); //cover card face again
        audioSource.Play();
    }
}
