using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersianUI.OtherControls
{
    public class DataGridView : System.Windows.Forms.DataGridView
    {
        public DataGridView()
        {
            this.Font = new Font("IRANSans", 12);
            this.EnableHeadersVisualStyles = false;
        }
    }
}
