namespace ControlApp.Commands.Builders;

public abstract class CommandBuilder(string displayName) {
    public string DisplayName {
        get {
            return displayName;
        }
    }
    
    public abstract void ConfigureInputPanel(Panel inputPanel);

    public abstract Command? BuildCommand(Panel inputPanel);
}