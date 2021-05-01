using System.Windows.Input;

namespace DiaTagger.Interfaces {
    public interface IFormKeyboardFocusChanged {
        event KeyboardEventHandler KeyboardFocusForValidationChanged;
    }
}
