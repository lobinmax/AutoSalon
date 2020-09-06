using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class frГрафикТО : Form
{
    public frГрафикТО(Guid UIDТовара)
    {
        InitializeComponent();
        this.Text = UIDТовара.ToString();
    }
}
