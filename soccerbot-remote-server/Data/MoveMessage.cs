[Serializable]
public class MoveMessage
{
    public Guid Id {get;set;}
    public int Degrees {get;set;}
    public int Magnitude {get;set;}

    #region Methods
    public MoveMessage(int degrees, int magnitude){
        Id = Guid.NewGuid();
        Degrees = degrees;
        Magnitude = magnitude;
    }
    #endregion
}