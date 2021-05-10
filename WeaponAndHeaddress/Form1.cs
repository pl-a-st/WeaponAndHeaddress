using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DALs;

namespace WeaponAndHeaddress
{
    public partial class Form1 : Form
    {
        DB db;
        
        public Form1()
        {
            InitializeComponent();
            db = new DB();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            db.Connect();
            db.InsertData(TableType.Weapon, tbxName.Text, (int)nudDamage.Value);
            db.Disconnect();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Change_Click(object sender, EventArgs e)
        {
            db.Connect();
            db.RemooveData(TableType.Weapon, tbxName.Text, (int)nudDamage.Value,(int)nudID.Value);
            db.Disconnect();
        }
    }
}
