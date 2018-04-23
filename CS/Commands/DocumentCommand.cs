using System;
using System.Windows.Input;
using DXRibbonNotepad.Model;
namespace DXRibbonNotepad.Commands {
    public class DocumentCommand : ICommand {
        public event EventHandler CanExecuteChanged {
            add {
                if(canExecute != null)
                    CommandManager.RequerySuggested += value;
            }
            remove {
                if(canExecute != null)
                    CommandManager.RequerySuggested -= value;
            }
        }
        public DocumentCommand(Action<Documents> execute)
            : this(execute, null) {
        }
        public DocumentCommand(Action<Documents> execute, Func<Documents, bool> canExecute) {
            if(execute == null)
                throw new ArgumentNullException("execute");

            this.execute = execute;
            this.canExecute = canExecute;
        }
        public virtual bool CanExecute(object parameter) {
            if(canExecute == null || parameter == null) return true;
            if(!(parameter is Documents))
                throw new ArgumentException("parameter");
            return canExecute((Documents)parameter);
        }
        public virtual void Execute(object parameter) {
            if(!(parameter is Documents))
                throw new ArgumentException("parameter");
            execute((Documents)parameter);
        }

        Action<Documents> execute;
        Func<Documents, bool> canExecute;
    }
}