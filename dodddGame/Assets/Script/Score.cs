using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
    [SerializeField]
    int score ;
    //show score ui
    public Text showScore;

    [SerializeField]
    Vector3 _lastPosition;

    // Use this for initialization
    void Start()
    {
        score = 0;
        _lastPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if ((this.transform.position.y - _lastPosition.y) > 0)
            score++;

        _lastPosition = this.transform.position;

        showScore.text = score.ToString();
        FinalScore();
    }

    void FinalScore()
    {
        PlayerPrefs.SetInt("FinalScore", score);
    }


    void OnGUI()
    {
        GUILayout.Label("Score : " + score);
    }
}
