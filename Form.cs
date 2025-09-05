using System.Windows.Forms;
using System.ComponentModel;
namespace tiktokshop_sku_counter
{
    public partial class Form : System.Windows.Forms.Form
    {
        private BindingList<File> _files = new BindingList<File>();

        public Form()
        {
            InitializeComponent();

        }
        private void FormLoad(object sender, EventArgs e)
        {
            uxDataGridView.DataSource = _files;
        }
        private void AddClick(object sender, EventArgs e)
        {
            try
            {
                if (uxOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    File file = new File(Path.GetFileName(uxOpenFileDialog.FileName), uxOpenFileDialog.FileName);
                    _files.Add(file);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }


        }

        private void DataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                MessageBox.Show("BUTTON!");
            }
        }
    }
}
