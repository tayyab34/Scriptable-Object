using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Testing : MonoBehaviour
{
    public Card card;
    public TextMeshProUGUI nametext;
    public TextMeshProUGUI descriptiontext;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(card.Name);
        Debug.Log(card.Description);
        descriptiontext.text = card.Description;
        nametext.text = card.Name;
    }
}
