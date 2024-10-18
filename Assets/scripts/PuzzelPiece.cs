using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PuzzelPiece : MonoBehaviour
{
    [SerializeField] private SpriteRenderer renderer; 
    private bool dragging, placed;

    private Vector2 offset, originalPosition;

    private PuzzelSlot slot;

    public void Init(PuzzelSlot slot)
    {
        renderer.sprite = slot.renderer.sprite; //tale ouit 
        this.slot = slot;
    }
    void Awake()
    {
        originalPosition = transform.position;
    }
    void Update()
    {
        if (placed)
            return; 
        if (!dragging)
            return;

        var mousePosition = (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePosition - offset;
    }
     void OnMouseDown()
    {
        dragging = true; 
    }

    Vector2 GetMousePosition()
    {
        return Camera.main.WorldToScreenPoint(Input.mousePosition);
    }

    void OnMouseUp()
    {
         if (Vector2.Distance(transform.position, slot.transform.position) < 0.5)
         {
            transform.position = slot.transform.position;
            placed = true;
            ScoreScript.instance.AddPoints();
            
         }
         else
         {
                transform.position = originalPosition;
                dragging = false; 
         }

    }
}
