namespace ErraiTechnicalTest
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

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
                if (!Double.TryParse(couldBeNum, out Double _num))
                {
                    return (true, $"Invalid element \"{couldBeNum}\"");
                }
            }
            
            return (false, "ok");
        }


        private void Main_Load(object sender, EventArgs e)
        {
            // Reset controls state
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

            Double[] splitInput = input.Split(',')
                .Select( val =>  Double.Parse(val))
                .ToArray();

            Sort(splitInput);
        }

        private async void Sort(Double[] arr)
        {
            Task<(Double[], Double)> quickSortTask =  SortingAlgo.QuickSortAlgoAsync(arr);

            (Double[] quickSortResult, Double quickSortTime) = await quickSortTask;
            SetControl(labelQuickSortTimer, dataGridViewQuickSort, quickSortTime, quickSortResult);
        }

        private static void SetControl(Label timerLabel, DataGridView gridView, Double time, Double[] gridData)
        {
            timerLabel.Text = time.ToString();
            gridView.DataSource = gridData
                .Select(val => new {No = val})
                .ToList();
        }
    }
}