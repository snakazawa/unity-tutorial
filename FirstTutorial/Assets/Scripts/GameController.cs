using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Text scoreLabel;
    public GameObject winnerLabelObject;

    public void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;

        scoreLabel.text = count.ToString();

        if (count == 0)
        {
            winnerLabelObject.SetActive(true);
        }
    }
}
