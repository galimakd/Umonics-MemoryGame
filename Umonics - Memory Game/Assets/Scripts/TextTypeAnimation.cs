using UnityEngine;
using System.Collections;

public class TextTypeAnimation : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI text;
    private int initLength;

    [SerializeField] GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        initLength = text.text.Length;
        text.maxVisibleCharacters = 0;

        StartCoroutine(AnimateText());
    }

    bool skip = false;

    void Update(){
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("clicked");
            skip = true;
        }
    }

    private IEnumerator AnimateText(){
        yield return new WaitForSeconds(.5f);

        while(true){
            yield return new WaitForSeconds(.05f);
            text.maxVisibleCharacters++;
            if(skip == true) text.maxVisibleCharacters = initLength;
            if(text.maxVisibleCharacters == initLength){
                button.SetActive(true);
                break;
            }
        }
    }
}
