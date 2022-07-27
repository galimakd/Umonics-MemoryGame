using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Main card script, may comments na rin sa functions

public class MainCardScript : MonoBehaviour
{
    [SerializeField] private SceneControllerScript controller;
    [SerializeField] private GameObject BackCard;

    //Change photo on click
    public void OnMouseDown() {
        if(BackCard.activeSelf && controller.canReveal) {
            BackCard.SetActive(false);
            controller.CardRevealed(this);
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
    }

}
