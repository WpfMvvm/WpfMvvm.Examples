using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Markup;

namespace WpfMvvmApp
{
    [ContentProperty(nameof(Dictionary))]
    public partial class ViewModel: ISupportInitialize
    {
        private RelayCommand _exampleCommand;

        public IDictionary Dictionary { get; set; } = new Dictionary<object, object>();
        /// <summary>Объект находится в состояни инициализации.</summary>
        public bool IsInit { get; private set; }
        public void BeginInit() => IsInit = true;

        public void EndInit()
        {
            IsInit = false;

        }

        public RelayCommand ExampleCommand => _exampleCommand
            ?? (_exampleCommand = new RelayCommand(ExampleMethod, ExampleCanMethod));

        private void ExampleMethod(object obj)
        {
            
        }

        private bool ExampleCanMethod(object arg)
        {
            return true;
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute?.Invoke(parameter) ?? true;
        }

        public void Execute(object parameter)
        {
            execute?.Invoke(parameter);
        }

        public void RaiseCanExecuteChanged()
            => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
