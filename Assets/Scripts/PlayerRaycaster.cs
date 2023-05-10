using UnityEngine;
using UnityEngine.UI;

public class PlayerRaycaster : MonoBehaviour
{
    [SerializeField] private Transform camTransform;
    [SerializeField] private Image crosshair;

    private void Update()
    {
		if (Physics.Raycast(camTransform.position, camTransform.forward, out RaycastHit hit))
		{
			Debug.Log($"Hit {hit.collider.gameObject.name}");
		}
    }
}