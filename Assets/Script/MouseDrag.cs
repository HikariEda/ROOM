using UnityEngine;

public class MouseDrag : MonoBehaviour
{
	public bool on = true;

	void OnMouseDrag()
	{
		// コメント
		if (on) {
			Vector3 objectPointInScreen
		= Camera.main.WorldToScreenPoint (this.transform.position);

			Vector3 mousePointInScreen
		= new Vector3 (Input.mousePosition.x,
				 Input.mousePosition.y,
				 objectPointInScreen.z);

			Vector3 mousePointInWorld = Camera.main.ScreenToWorldPoint (mousePointInScreen);
			mousePointInWorld.z = this.transform.position.z;
			this.transform.position = mousePointInWorld;
		}

	}
}