using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ScrolingBG : MonoBehaviour
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
