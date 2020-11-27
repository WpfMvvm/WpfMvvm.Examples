using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfMvvm.Converters.Examples
{
    /// <summary>Базовый класс с реализацией <see cref="INotifyPropertyChanged"/>.</summary>
    public abstract class BaseInpc : INotifyPropertyChanged
    {
        /// <inheritdoc cref="INotifyPropertyChanged"/>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>Защищённый метод для создания события <see cref="PropertyChanged"/>.</summary>
        /// <param name="propertyName">Имя изменившегося свойства. 
        /// Если зачение не задано, то используется имя метода в ктором был вызов.</param>
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>Защищённый метод для присвоения значения полю и создания события <see cref="PropertyChanged"/>.</summary>
        /// <typeparam name="T">Тип поля и присваиваемого значения.</typeparam>
        /// <param name="propertyFiled">Ссылка на поле.</param>
        /// <param name="newValue">Присваиваемое значение.</param>
        /// <param name="propertyName">Имя изменившегося свойства. 
        /// Если зачение не задано, то используется имя метода в ктором был вызов.</param>
        /// <remarks>Метод предназначен для использования в сеттере свойства. 
        /// Для проверки на изменение используется метод <see cref="object.Equals(object, object)"/>.
        /// Если присваиваемое знанчение не эквивалетно значению поля, то оно присваивается полю,
        /// после чего создаётся событие <see cref="PropertyChanged"/> путём вызова
        /// метода <see cref="RaisePropertyChanged(string)"/>
        /// с передачей ему параметра <paramref name="propertyName"/>.</remarks>
        protected void Set<T>(ref T propertyFiled, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!object.Equals(propertyFiled, newValue))
            {
                propertyFiled = newValue;
                RaisePropertyChanged(propertyName);
            }
        }
    }
}
