using UnityEngine;

public class TankSlection : MonoBehaviour
{
    public TankSpawner tankSpawner;

    public void BlueTankSlector()
    {
        tankSpawner.CreateTank(TankTypes.BlueTank);
        this.gameObject.SetActive(false);
    }

    public void GreenTankSlector()
    {
        tankSpawner.CreateTank(TankTypes.GreenTank);
        this.gameObject.SetActive(false);
    }

    public void RedTankSlector()
    {
        tankSpawner.CreateTank(TankTypes.RedTank);
        this.gameObject.SetActive(false);
    }
}
