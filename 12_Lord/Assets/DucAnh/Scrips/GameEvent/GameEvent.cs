using NabaGame.Core.Runtime.EventManager;

public class OnSkipDayEvent : GameEvent 
{
    public OnSkipDayEvent() 
    {
    
    }
}


public class OnChangeResource: GameEvent 
{
    int resourceQuanty;
    public OnChangeResource(int qty)
    {
        resourceQuanty = qty;
    }
}