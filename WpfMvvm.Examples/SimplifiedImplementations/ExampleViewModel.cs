namespace Simplified
{
    public class ExampleViewModel : BaseInpc
    {
        private int _number;
        private int _modNumber;
        private int _mod;

        /// <summary>Любое целое число.</summary>
        public int Number { get => _number; set => Set(ref _number, value); }

        /// <summary>Любое целое число.</summary>
        public int Mod { get => _mod; set => Set(ref _mod, value); }

        /// <summary>Модуль числа Number по основанию Mod.</summary>
        public int ModNumber { get => _modNumber; private set => Set(ref _modNumber, value); }

        protected override void OnPropertyChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnPropertyChanged(propertyName, oldValue, newValue);

            // Проверяется имя изменившегося свойства и производятся необходимые действия
            if (propertyName == nameof(Number) || propertyName == nameof(Mod))
                ModNumber = Number % Mod;
        }
    }
}
