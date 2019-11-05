using System;
using System.Windows.Input;

namespace WpfApp4.Core.Command
{
    /// <summary>
    /// Определяет команду, которая реализует ICommand
    /// </summary>
    public class RelayCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;

        /// <summary>
        /// Ивент, уведомляющий о том, что возможность выполнения комманды изменена
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса RelayCommand
        /// </summary>
        /// <param name="execute">Делегат выполнения команды</param>
        /// <param name="canExecute">Делегат, определяющий возможность выполнения команды</param>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// Определяет возможность выполнения команды
        /// </summary>
        /// <param name="parameter">Параметр, с которым будет вызван делегат canExecute</param>
        /// <returns>Возможен ли вызов команды</returns>
        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        /// <summary>
        /// Позволяет вызвать команду
        /// </summary>
        /// <param name="parameter">Параметр, с которым будет вызван делегат execute</param>
        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
