using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lookup
{
    public partial class DataLookUp : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        String primary;
        public DataLookUp()
        {
            InitializeComponent();
        }

        private void DataLookUp_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tbl_Users.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            session.primary = this.dataGridView1[0, e.RowIndex].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
