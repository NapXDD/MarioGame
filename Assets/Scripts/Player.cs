using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerSpriteRender smallRenderer;
    public PlayerSpriteRender bigRenderer;

    public DeadAnimation deadAnimation { get; private set; }

    public bool big => bigRenderer.enabled;
    public bool small => smallRenderer.enabled;
    public bool dead => deadAnimation.enabled;

    private void Awake()
    {
        deadAnimation = GetComponent<DeadAnimation>();
    }

    public void Hit()
    {
        if (big)
        {
            Shrink();
        }
        else
        {
            Death();
        }
    }

    public void Shrink()
    {

    }

    public void Death()
    {
        smallRenderer.enabled = false;
        bigRenderer.enabled = false;
        deadAnimation.enabled = true;

        GameManager.Instance.ResetLevel(3f);
    }

}
