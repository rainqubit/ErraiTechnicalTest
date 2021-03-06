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
            Task<(Double[], Double)> bubbleSortTask =  SortingAlgo.BubbleSortAlgoAsync(arr);
            Task<(Double[], Double)> mergeSortTask =  SortingAlgo.MergeSortAlgoAsync(arr);
            Task<(Double[], Double)> gcfSortTask =  SortingAlgo.GCFSortAlgoAsync(arr);

            (Double[] quickSortResult, Double quickSortTime) = await quickSortTask;
            SetControl(labelQuickSortTimer, dataGridViewQuickSort, quickSortTime, quickSortResult);

            (Double[] bubbleSortResult, Double bubbleSortTime) = await bubbleSortTask;
            SetControl(labelBubbleSortTimer, dataGridViewBubbleSort, bubbleSortTime, bubbleSortResult);

            (Double[] mergeSortResult, Double mergeSortTime) = await mergeSortTask;
            SetControl(labelMergeSortTimer, dataGridViewMergeSort, mergeSortTime, mergeSortResult);

            (Double[] gcfSortResult, Double gcfSortTime) = await gcfSortTask;
            SetControl(labelGCFSortTimer, dataGridViewGCFSort, gcfSortTime, gcfSortResult);
        }

        private static void SetControl(Label timerLabel, DataGridView gridView, Double time, Double[] gridData)
        {
            timerLabel.Text = $"{time} ms";
            gridView.DataSource = gridData
                .Select(val => new {No = ((decimal)val)})
                .ToList();

            foreach (DataGridViewColumn column in gridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            }
            gridView.Refresh();

        }
    }
}