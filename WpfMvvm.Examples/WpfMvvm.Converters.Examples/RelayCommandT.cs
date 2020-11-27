using System;

namespace WpfMvvm.Converters.Examples
{
    public class RelayCommand<T> : RelayCommand
    {
        public RelayCommand(Action<T> execute, Func<T, bool> canExecute = null)
            : base
            (
                  p =>
                  {
                      if (p is T t)
                          execute(t);
                  },
                  p => (p is T t) && (canExecute?.Invoke(t) ?? true)
            )
        { }
    }
}
