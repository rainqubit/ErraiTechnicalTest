namespace ErraiTechnicalTest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validate input to make sure it's a valid CSV
        /// and all the elements are valid double type
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static (bool err, string msg) Validate(string input)
        {
            input = input.Trim();

            if (String.IsNullOrEmpty(input))
            {
                return (true, "Please input something");
            }

            string[] splitInput = input.Split(',');

            if(splitInput.Length <= 0)
            {
                return (true, "Invalid input format");
            }

            foreach(string couldBeNum in splitInput)
            {
                double _num;
                if (!Double.TryParse(couldBeNum, out _num))
                {
                    return (true, $"Invalid element {couldBeNum}");
                }
            }
            
            return (false, "ok");
        }


        private void Main_Load(object sender, EventArgs e)
        {
            // Reset controls state

            this.dataGridViewQuickSort.DataSource = new Double[0];
            this.dataGridViewBubbleSort.DataSource = new Double[0];
            this.dataGridViewMergeSort.DataSource = new Double[0];
            this.dataGridViewGCFSort.DataSource = new Double[0];

            this.labelQuickSortTimer.Text = "";
            this.labelBubbleSortTimer.Text = "";
            this.labelMergeSortTimer.Text = "";
            this.labelGCFSortTimer.Text = "";
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            string input = this.textBoxInput.Text;

            (bool err, string msg) = Validate(input);

            Console.WriteLine(msg);

            if (err)
            {
                MessageBox.Show(msg);
                return;
            }
        }
    }
}