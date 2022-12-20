using UnityEngine;
using System.Threading.Tasks;

public class CameraEffects : MonoBehaviour
{
    [SerializeField] private float magnitude;
    [SerializeField] private float duration;

    private Vector3 RandomCameraPosition()
    {
        int randomX = Random.Range(-2, 2);
        int randomY = Random.Range(-2, 2);
        return new Vector3(randomX, randomY, -10);
    }

    public async void ShakeCamera(Vector3 initialCameraPos)
    {
        GameObject camera = this.gameObject;
        Quaternion cameraRotation = camera.transform.rotation;

        float endTime = Time.time + duration;

        while (Time.time < endTime)
        {
            Vector3 randomCameraPos = RandomCameraPosition();

            // lerp camera
            Vector3 newCameraPos = Vector3.Lerp(camera.transform.position, randomCameraPos, magnitude);

            // set new camera pos
            camera.transform.SetPositionAndRotation(newCameraPos, cameraRotation);
            await Task.Yield();
        }

        // reset camera to its original position
        camera.transform.SetPositionAndRotation(initialCameraPos, cameraRotation);
    }

}
