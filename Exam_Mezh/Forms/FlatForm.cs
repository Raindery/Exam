using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam_Mezh.Entities;
using System.Data.Entity;

namespace Exam_Mezh.Forms
{
    public partial class FlatForm : Form
    {
        FlatsContext db;
        public FlatForm()
        {
            InitializeComponent();
            db = new FlatsContext();
            db.Clients.Load();
            db.Types.Load();

            cbType.DataSource = db.Types.Local.ToBindingList();
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "Id";


            cbClient.DataSource = db.Clients.Local.ToBindingList();
            cbClient.DisplayMember = "Name";
            cbClient.ValueMember = "Id";
           
            
            
        }

        private void Flat_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
