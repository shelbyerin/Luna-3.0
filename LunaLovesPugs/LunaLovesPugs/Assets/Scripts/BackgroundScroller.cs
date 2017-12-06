using System.Collections;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed;
    float pos = 0;

    public static BackgroundScroller current;
    private Vector2 startPosition;

    void Start ()
    {
        current = this;
        //startPosition = transform.position;
    }

    void Update ()
    {
      pos += scrollSpeed;
      if (pos > 1.0f)
      {
          pos -= 1.0f;
      }

      //renderer.material.mainTextureOffset = new Vector2(pos, 0);
        //float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSize);
        //transform.position = startPosition + Vector2.right * newPosition;
    }
}
