using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCardScript2 : MonoBehaviour
{
    [SerializeField] private SceneControllerScript2 controller2;
    [SerializeField] private GameObject BackCard;
    [SerializeField] private AudioSource audioSource;

    //Change photo on click
    public void OnMouseDown() {
        if(BackCard.activeSelf && controller2.canReveal) {
            BackCard.SetActive(false);
            controller2.CardRevealed(this);
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
