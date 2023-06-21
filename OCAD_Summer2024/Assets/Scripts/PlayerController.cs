using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(GravityAffected))]
public class PlayerController : MonoBehaviour
{
    public static PlayerController Main;

    [Header("Resources")]
    public int Gold = 100;
    public Inventory inventory;
    public float CurrentResources;

    public GameObject goldText;    

    [Header("UI")]
    public TMP_Text PromptDisplay = null;

    [Header("Other")]
    [Range(0, 25)] public float Speed;
    private Rigidbody rb;
    public GameObject mesh;
    public CameraController camController;

    public float JumpForce = 1.0f;
    public float f_AirFrictionForce = 100.0f;
    [Range(0, 25)] public float MaxSpeed = 10.0f;

    [Header("Interactable")]
    public Interactable target = null;

    [Header("Upgrades")]
    public int SpeedUpgrade = 0;
    public int CargoUpgrade = 0;

    private void Awake()
    {
        if (Main == null) Main = this;        
        else Destroy(this.gameObject);        

        rb = GetComponent<Rigidbody>();

        // Initialize Upgrades
        UpgradeSpeed(0);
        UpgradeCargo(0);

        //set UI text
        UpdateGoldText();
    }

    // Update is called once per frame
    void Update()
    {
        Motion();
        Jump();

        SpeedLimiter();

        if (Input.GetKeyDown(KeyCode.E))
        {
            target.Interact(this);
            PromptDisplay.text = "";
            PromptDisplay.enabled = false;
        }
    }

    public void UpgradeSpeed(int level)
    {
        SpeedUpgrade = level;
        Speed = 6 + (level * 4);
    }

    public void UpgradeCargo(int level)
    {
        CargoUpgrade = level;
        inventory.MaxInventory = 7 + (level * 3);
    }

    private void SpeedLimiter()
    {        
        // TODO: Fix this speed limiter so that it doesn't account velocity towards the planet.  We might have to break up the velocity into two parts before assembling it as a final velocity that we set rb.velocity to.
        // This way we can manipulate velocity on the horizontal plane separately from the velocity on the vertical plane. We did something like this in Sea Drive.
        if (rb.velocity.magnitude > MaxSpeed)
        {           
            // Get the direction of the velocity
            Vector3 velocity = rb.velocity;

            // Get the inverse of the direction of velocity
            Vector3 inverse = -velocity;

            // Calculate how fast over you're going
            float excess = Mathf.Abs(MaxSpeed - rb.velocity.magnitude);

            // Apply a force in opposite direction proportional to the amount of excess speed.
            rb.AddForce(inverse * excess);
        }
    }

    private void Motion()
    {
        Vector3 Vec = Vector3.zero;

        // Get direction of movement based on whether we're rotating the camera with the mesh or not
        Quaternion direction = (camController.RotateWithMesh) ?
            mesh.transform.rotation : camController.cam.transform.rotation;

        // X Axis Movement (Left to Right)
        Vec += direction * ((camController.RotateWithMesh) ? Vector3.right : Vector3.right) * Input.GetAxisRaw("Horizontal");

        // Z Axis Movement (Forward/Backwards)
        Vec += direction * ((camController.RotateWithMesh) ? Vector3.forward : Vector3.up) * Input.GetAxisRaw("Vertical");

        // Add Movement Force
        rb.AddForce(Vec.normalized * Speed * 2);
    }

    private void Jump()
    {
        if (GetComponent<GravityAffected>().Grounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * JumpForce);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Interactable" && target == null)
        {
            if (!PromptDisplay.enabled) {
                PromptDisplay.text = "'E' to Interact";
                PromptDisplay.enabled = true;
            }

            target = other.GetComponent<Interactable>();                                  
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Interactable")
        {
            if (PromptDisplay.enabled)
            {
                PromptDisplay.text = "";
                PromptDisplay.enabled = false;
            }

            target = null;
        }
    }

    public void UpdateGoldText()
    {
        goldText.GetComponent<TMP_Text>().text = Gold.ToString();
    }
}
