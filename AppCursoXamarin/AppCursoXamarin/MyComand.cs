using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AppCursoXamarin
{
    public class MyComand : ICommand
    {
        private Action action;
        private Func<bool> canExecute;

        public event EventHandler CanExecuteChanged;

        public MyComand(Action action,Func<bool> canExecute)
        {
            this.action = action;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute();
        }

        public void Execute(object parameter)
        {
            this.action();
        }
        public void ReEvaluateCanExecute()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
