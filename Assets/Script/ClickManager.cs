using UnityEngine;
using UnityEngine.InputSystem;

public class ClickManager : MonoBehaviour
{
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("คลิกซ้ายเกิดขึ้นแล้ว"); // ✅ ตรวจว่าคลิกทำงาน

            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            Debug.Log("ตำแหน่งเมาส์ในโลก: " + mousePos);

            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);
            if (hit.collider != null)
            {
                Debug.Log("Raycast โดนวัตถุ: " + hit.collider.name);

                IClickable clickable = hit.collider.GetComponent<IClickable>();
                if (clickable != null)
                {
                    Debug.Log("พบ IClickable → เรียก OnClick()");
                    clickable.OnClick();
                }
                else
                {
                    Debug.Log("Raycast โดนวัตถุ แต่ไม่มี IClickable");
                }
            }
            else
            {
                Debug.Log("Raycast ไม่โดนวัตถุใดเลย");
            }
        }
    }
}
