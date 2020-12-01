// Context 클래스
public class Context
{
    private State state;

    // Constructor
    public Context(State state)
    {
        this.state = state;
    }

    // sets the state
    public void setState(State state)
    {
        this.state = state;
    }

    public void Request()
    {
        state.Handle();
    }
};
