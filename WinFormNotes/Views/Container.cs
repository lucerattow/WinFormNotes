using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormNotes.Views
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
            OpenChildren(new TaskPanel(this));
        }

        /// <summary>
        /// Elimina todas las ventanas abiertas del contenedor.
        /// </summary>
        public void CloseChildren()
        {
            PnlContainer.Controls.Clear();
        }

        /// <summary>
        /// Abre una ventana dentro del contenedor
        /// </summary>
        /// <param name="children">Ventana que sera mostrada dentro del contenedor</param>
        public void OpenChildren(UserControl children)
        {
            PnlContainer.Controls.Clear();
            PnlContainer.Controls.Add(children);
        }
    }
}
