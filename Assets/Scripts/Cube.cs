using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject textui = GameObject.Find("Score");
        int score = int.Parse(textui.GetComponent<TextMeshProUGUI>().text);
        score += 100;
        textui.GetComponent<TextMeshProUGUI>().text = score.ToString();

        Destroy(this.gameObject);
    }
}
