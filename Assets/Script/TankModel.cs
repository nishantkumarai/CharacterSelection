using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float movementSpeed;
    public float rotationSpeed;
    public TankTypes tankTypes;
    public Material color;

    public TankModel(float _movementSpeed, float _rotationSpeed, TankTypes _tankTypes, Material _color)
    {
        movementSpeed = _movementSpeed;
        rotationSpeed = _movementSpeed;
        tankTypes = _tankTypes;
        color = _color;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
