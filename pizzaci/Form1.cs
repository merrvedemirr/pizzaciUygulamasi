namespace pizzaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           listBox1.Items.Add(textBox1.Text);
           listBox1.Items.Add(textBox2.Text);
           listBox1.Items.Add(textBox3.Text);
           listBox1.Items.Add(comboBox1.Text);
           listBox1.Items.Add(comboBox2.Text);
            listBox1.Items.Add(label8.Text + " "+ label9.Text + " " + label10.Text + " " + label11.Text + " " + label12.Text + " " + label13.Text);
            listBox1.Items.Add("****************");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = checkBox1.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = checkBox2.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = checkBox3.Text;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = checkBox4.Text;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = checkBox5.Text;  
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            label13.Text = checkBox6.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
        }
    }
}