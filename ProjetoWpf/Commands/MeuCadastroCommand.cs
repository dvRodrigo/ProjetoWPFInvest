﻿using ProjetoWpf.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjetoWpf.Commands
{
    public class MeuCadastroCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var telaCadastro = new WinMeuCadastro();
            telaCadastro.Show();
        }
    }
}
