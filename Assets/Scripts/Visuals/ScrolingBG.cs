using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Scrolls image resource to make it "move"
/// </summary>

[RequireComponent(typeof(Image))]

public class ScrollingBG : MonoBehaviour
{

    public float speed;
    public Vector2 direction;

    Image image;
    
    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {

        image.material.mainTextureOffset += -direction.normalized * Time.deltaTime * speed / 100;
    }
}
