using UnityEngine;

public class ControllerAIData : MonoBehaviour
{
    private GameObject _padAI;
    public GameObject PadAI => _padAI;
    private GameObject _padPlayer;
    public GameObject PadPlayer => _padPlayer;
    private GameObject _ball;
    public GameObject Ball => _ball;
    [SerializeField] private float _ballAlignmentAcceptance;
    public float BallAlignmentAcceptance => _ballAlignmentAcceptance;

    public void FindPadAI()
    {
        _padAI = GameObject.Find("PadAI");
    }

    public void FindPadPlayer()
    {
        _padPlayer = GameObject.Find("PadPlayer");
    }

    public void FindBall() 
    {
        _ball = GameObject.Find("Ball"); 
    }

    void Awake()
    {
        FindPadAI();
        FindPadPlayer();
        FindBall();
    }
}
