namespace C_;

public interface IKeyboard{
    void PressKey();
}

public interface IMouse{
    void PressKey();
}

public class WiredKeyboard(): IKeyboard{
    public void PressKey() { }
}

public class WirelessKeyboard(): IKeyboard{
    public void PressKey() { }
}

public class WiredMouse(): IMouse{
    public void PressKey() { }
}

public class WirelessMouse(): IMouse{
    public void PressKey() { }
}
public class DependencyInversionPrinciple
{
    public class Macbook{
        public IKeyboard Keyboard;
        public IMouse Mouse;
        public Macbook(IKeyboard keyboard, IMouse mouse){
            this.Keyboard = keyboard;
            this.Mouse = mouse;
        }
    }

}
