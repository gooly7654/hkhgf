using UnityEngine;

public class Target : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
        if (gameManager != null)
        {
            gameManager.TargetHit();
            Destroy(gameObject);
        }
    }
}
