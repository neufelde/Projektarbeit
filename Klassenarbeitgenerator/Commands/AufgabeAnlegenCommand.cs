namespace Klassenarbeitgenerator.Commands
{
    using System;
    using System.Windows.Input;

    public class AufgabeAnlegenCommand : ICommand
    {
        #region Fields and Constants
        private MainViewModel mainViewModel;
        #endregion

        #region Constructors and Destructors
        public AufgabeAnlegenCommand(MainViewModel vm)
        {
            this.mainViewModel = vm;
        }
        #endregion

        #region ICommand
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
