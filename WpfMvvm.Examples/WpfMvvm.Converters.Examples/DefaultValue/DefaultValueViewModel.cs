using Simplified;
using System.Windows;
using System.Windows.Input;

namespace WpfMvvm.Converters.Examples.DefaultValue
{
    public class DefaultValueViewModel : BaseInpc
    {
        private Point _currentPoint;
        private ICommand _changePointCommand;

        public Point CurrentPoint { get => _currentPoint; set => Set(ref _currentPoint, value); }

        public ICommand ChangePointCommand => _changePointCommand
            ?? (_changePointCommand = new RelayCommand<Point>(point => CurrentPoint = point));

    }

}
