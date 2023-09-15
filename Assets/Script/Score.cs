using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text scoreText;
    public static float scoreValue;
    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
        scoreText.text = scoreValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = scoreValue.ToString();
    }
}
