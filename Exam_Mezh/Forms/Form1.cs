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
using Exam_Mezh.Forms;

namespace Exam_Mezh
{
    public partial class Form1 : Form
    {
        FlatsContext db;
        public Form1()
        {
            
            InitializeComponent();
            db = new FlatsContext();
            db.Types.Load();
            db.Flats.Load();
            db.Clients.Load();


            dataGridView1.DataSource = db.Flats.Local.ToList();
            dataGridView1.Columns[0].Visible = false;

            
            
                
                
                if (db.Types.Count() == 0 && db.Clients.Count() == 0)
                {
                    db.Types.Add(Entities.Type.CreateType("Студия"));
                    db.Types.Add(Entities.Type.CreateType("1к"));
                    db.Types.Add(Entities.Type.CreateType("1к"));
                    db.Types.Add(Entities.Type.CreateType("2к"));
                    db.Types.Add(Entities.Type.CreateType("3к"));
                    db.Types.Add(Entities.Type.CreateType("Дом"));
                    db.Clients.Add(Client.CreateClient("Test", "Test", 1, true));
                    db.SaveChanges();

                }
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           FlatForm flatForm = new FlatForm();

            DialogResult result = flatForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;


            var flat = Flat.CreateFlat(flatForm.cbReqType.SelectedItem.ToString(), (int)flatForm.numFloor.Value, (float)flatForm.numFootage.Value, flatForm.dateBuilding.Value.Date, flatForm.elevator.Checked, (int)flatForm.cbType.SelectedValue, (int)flatForm.cbClient.SelectedValue);

            using (db)
            {
                db.Flats.Add(flat);
                db.SaveChanges();
            }
        }
    }
}
