using Prism.Mvvm;
using snakegame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakegame.ViewModels
{
    internal class CellVM : BindableBase
    {
        public int Row { get; }
        public int Column { get; }

        private CellType _cellType = CellType.None;

        public CellType CellType
        {
            get => _cellType; 
            set 
            { 
                _cellType = value; 
                RaisePropertyChanged(nameof(CellType));
            }
        }

        public CellVM(int row, int column)
        {
            Row = row;
            Column = column;  
        }
    }
}
