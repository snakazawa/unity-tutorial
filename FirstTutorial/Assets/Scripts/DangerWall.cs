using UnityEngine;
using UnityEngine.SceneManagement;

public class DangerWall : MonoBehaviour
{

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            int idx = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(idx);
        }
    }
}
