using System.Text;

namespace Calculator
{
    public partial class Form1 : Form
    {
        StringBuilder nunmber1 = new StringBuilder();
        StringBuilder nunmber2 = new StringBuilder();
        Calc calc = new Calc();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void numberEntry(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (this.calc.Action.HasValue)
                    this.nunmber2.Append(button.Text);
                else
                    this.nunmber1.Append(button.Text);
            }
            this.richTextBox1.Text = $"{this.nunmber1}{this.calc.Action.GetValueOrDefault()}{this.nunmber2}";
        }
    }
}
