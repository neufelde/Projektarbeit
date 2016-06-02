namespace Klassenarbeitgenerator
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MainViewModel
    {
        #region Fields and Constants
        private MainWindow mainWindow;       
        #endregion

        #region Constructors and Destructors
        public MainViewModel(MainWindow window)
        {
            this.mainWindow = window;
        }
        #endregion
    }
}
