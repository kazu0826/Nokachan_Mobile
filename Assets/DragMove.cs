using UnityEngine;
using TMPro;

public class DragMove : MonoBehaviour
{

	[SerializeField] private float slideSpeed = 2f; //���ړ��̃X�s�[�h�BInspector���Őݒ�
	public TextMeshProUGUI tm = null;
	public TextMeshProUGUI tm2 = null;

	private void Update()
	{
		PlayerInput();
		
	}

	private void PlayerInput()
	{
		//�������͂��Ȃ�������return����
		if (Input.touchCount <= 0) return;

		if (Input.GetTouch(0).phase == TouchPhase.Moved)
		{
			Vector3 touchPosition = Input.GetTouch(0).deltaPosition;
			
			Debug.Log(touchPosition);
			
			tm.text = string.Format("touchPosition.x: {0}", Input.GetTouch(0).deltaPosition);
			transform.Translate(new Vector3(touchPosition.x * slideSpeed * Time.deltaTime*-1,0,0), Space.World);
			tm2.text = string.Format("touchPosition.x * slideSpeed * Time.deltaTime.x: {0}", touchPosition.x * slideSpeed * Time.deltaTime);
		}
	}
}