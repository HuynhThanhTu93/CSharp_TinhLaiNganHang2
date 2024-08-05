namespace CSharp_TinhLaiNganHang
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (double i = 0.01; i < 0.101; i+=0.001)
            {
                cbxLai.Items.Add(String.Format("{0:P1}", Math.Round(i, 3)));
            }
            txtGui.Text = "10000000";
            cbxLai.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listKQ.Items.Clear();
            double Gui = Convert.ToInt64(txtGui.Text);
            int Nam = (int)numNam.Value;
            double laiSuat = double.Parse(cbxLai.SelectedItem.ToString().Replace("%", "")) / 100;
        }

        private void listKQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            listKQ.Text = Gui.ToString();
            listKQ.Text = Lai.ToString();
            listKQ.Text = nam.ToString();
            listKQ.Text = TienLai.ToString();
            listKQ.Text = Tiennhan.ToString();
        }
    }
}
