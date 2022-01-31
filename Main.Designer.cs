namespace ErraiTechnicalTest
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelGCFSort = new System.Windows.Forms.TableLayoutPanel();
            this.labelGCFSortTimer = new System.Windows.Forms.Label();
            this.labelGCFSort = new System.Windows.Forms.Label();
            this.dataGridViewGCFSort = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelMergeSort = new System.Windows.Forms.TableLayoutPanel();
            this.labelMergeSortTimer = new System.Windows.Forms.Label();
            this.labelMergeSort = new System.Windows.Forms.Label();
            this.dataGridViewMergeSort = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelBubbleSort = new System.Windows.Forms.TableLayoutPanel();
            this.labelBubbleSortTimer = new System.Windows.Forms.Label();
            this.labeBubbleSort = new System.Windows.Forms.Label();
            this.dataGridViewBubbleSort = new System.Windows.Forms.DataGridView();
            this.tableLayoutQuickSort = new System.Windows.Forms.TableLayoutPanel();
            this.labelQuickSortTimer = new System.Windows.Forms.Label();
            this.labelQuickSort = new System.Windows.Forms.Label();
            this.dataGridViewQuickSort = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelGCFSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGCFSort)).BeginInit();
            this.tableLayoutPanelMergeSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMergeSort)).BeginInit();
            this.tableLayoutPanelBubbleSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBubbleSort)).BeginInit();
            this.tableLayoutQuickSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuickSort)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.tableLayoutPanelMain.SetColumnSpan(this.textBoxInput, 3);
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Location = new System.Drawing.Point(40, 70);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(20, 50, 20, 20);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(857, 27);
            this.textBoxInput.TabIndex = 0;
            // 
            // buttonSort
            // 
            this.buttonSort.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSort.Location = new System.Drawing.Point(937, 70);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(20, 50, 20, 20);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(260, 29);
            this.buttonSort.TabIndex = 1;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 4;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelGCFSort, 3, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelMergeSort, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelBubbleSort, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxInput, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonSort, 3, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutQuickSort, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1237, 626);
            this.tableLayoutPanelMain.TabIndex = 2;
            // 
            // tableLayoutPanelGCFSort
            // 
            this.tableLayoutPanelGCFSort.ColumnCount = 1;
            this.tableLayoutPanelGCFSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGCFSort.Controls.Add(this.labelGCFSortTimer, 0, 2);
            this.tableLayoutPanelGCFSort.Controls.Add(this.labelGCFSort, 0, 0);
            this.tableLayoutPanelGCFSort.Controls.Add(this.dataGridViewGCFSort, 0, 1);
            this.tableLayoutPanelGCFSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGCFSort.Location = new System.Drawing.Point(937, 157);
            this.tableLayoutPanelGCFSort.Margin = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanelGCFSort.Name = "tableLayoutPanelGCFSort";
            this.tableLayoutPanelGCFSort.RowCount = 3;
            this.tableLayoutPanelGCFSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelGCFSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelGCFSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelGCFSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelGCFSort.Size = new System.Drawing.Size(260, 429);
            this.tableLayoutPanelGCFSort.TabIndex = 5;
            // 
            // labelGCFSortTimer
            // 
            this.labelGCFSortTimer.AutoSize = true;
            this.labelGCFSortTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGCFSortTimer.Location = new System.Drawing.Point(3, 385);
            this.labelGCFSortTimer.Name = "labelGCFSortTimer";
            this.labelGCFSortTimer.Size = new System.Drawing.Size(254, 44);
            this.labelGCFSortTimer.TabIndex = 2;
            this.labelGCFSortTimer.Text = "labelGCFSortTimer";
            this.labelGCFSortTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGCFSort
            // 
            this.labelGCFSort.AutoSize = true;
            this.labelGCFSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGCFSort.Location = new System.Drawing.Point(3, 0);
            this.labelGCFSort.Name = "labelGCFSort";
            this.labelGCFSort.Size = new System.Drawing.Size(254, 42);
            this.labelGCFSort.TabIndex = 0;
            this.labelGCFSort.Text = "GCF Sort";
            this.labelGCFSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewGCFSort
            // 
            this.dataGridViewGCFSort.AllowUserToAddRows = false;
            this.dataGridViewGCFSort.AllowUserToDeleteRows = false;
            this.dataGridViewGCFSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGCFSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGCFSort.Location = new System.Drawing.Point(3, 45);
            this.dataGridViewGCFSort.Name = "dataGridViewGCFSort";
            this.dataGridViewGCFSort.ReadOnly = true;
            this.dataGridViewGCFSort.RowHeadersWidth = 51;
            this.dataGridViewGCFSort.RowTemplate.Height = 29;
            this.dataGridViewGCFSort.Size = new System.Drawing.Size(254, 337);
            this.dataGridViewGCFSort.TabIndex = 1;
            // 
            // tableLayoutPanelMergeSort
            // 
            this.tableLayoutPanelMergeSort.ColumnCount = 1;
            this.tableLayoutPanelMergeSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMergeSort.Controls.Add(this.labelMergeSortTimer, 0, 2);
            this.tableLayoutPanelMergeSort.Controls.Add(this.labelMergeSort, 0, 0);
            this.tableLayoutPanelMergeSort.Controls.Add(this.dataGridViewMergeSort, 0, 1);
            this.tableLayoutPanelMergeSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMergeSort.Location = new System.Drawing.Point(638, 157);
            this.tableLayoutPanelMergeSort.Margin = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanelMergeSort.Name = "tableLayoutPanelMergeSort";
            this.tableLayoutPanelMergeSort.RowCount = 3;
            this.tableLayoutPanelMergeSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMergeSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelMergeSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMergeSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMergeSort.Size = new System.Drawing.Size(259, 429);
            this.tableLayoutPanelMergeSort.TabIndex = 4;
            // 
            // labelMergeSortTimer
            // 
            this.labelMergeSortTimer.AutoSize = true;
            this.labelMergeSortTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMergeSortTimer.Location = new System.Drawing.Point(3, 385);
            this.labelMergeSortTimer.Name = "labelMergeSortTimer";
            this.labelMergeSortTimer.Size = new System.Drawing.Size(253, 44);
            this.labelMergeSortTimer.TabIndex = 2;
            this.labelMergeSortTimer.Text = "labelMergeSortTimer";
            this.labelMergeSortTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMergeSort
            // 
            this.labelMergeSort.AutoSize = true;
            this.labelMergeSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMergeSort.Location = new System.Drawing.Point(3, 0);
            this.labelMergeSort.Name = "labelMergeSort";
            this.labelMergeSort.Size = new System.Drawing.Size(253, 42);
            this.labelMergeSort.TabIndex = 0;
            this.labelMergeSort.Text = "Merge Sort";
            this.labelMergeSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewMergeSort
            // 
            this.dataGridViewMergeSort.AllowUserToAddRows = false;
            this.dataGridViewMergeSort.AllowUserToDeleteRows = false;
            this.dataGridViewMergeSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMergeSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMergeSort.Location = new System.Drawing.Point(3, 45);
            this.dataGridViewMergeSort.Name = "dataGridViewMergeSort";
            this.dataGridViewMergeSort.ReadOnly = true;
            this.dataGridViewMergeSort.RowHeadersWidth = 51;
            this.dataGridViewMergeSort.RowTemplate.Height = 29;
            this.dataGridViewMergeSort.Size = new System.Drawing.Size(253, 337);
            this.dataGridViewMergeSort.TabIndex = 1;
            // 
            // tableLayoutPanelBubbleSort
            // 
            this.tableLayoutPanelBubbleSort.ColumnCount = 1;
            this.tableLayoutPanelBubbleSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBubbleSort.Controls.Add(this.labelBubbleSortTimer, 0, 2);
            this.tableLayoutPanelBubbleSort.Controls.Add(this.labeBubbleSort, 0, 0);
            this.tableLayoutPanelBubbleSort.Controls.Add(this.dataGridViewBubbleSort, 0, 1);
            this.tableLayoutPanelBubbleSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBubbleSort.Location = new System.Drawing.Point(339, 157);
            this.tableLayoutPanelBubbleSort.Margin = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanelBubbleSort.Name = "tableLayoutPanelBubbleSort";
            this.tableLayoutPanelBubbleSort.RowCount = 3;
            this.tableLayoutPanelBubbleSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelBubbleSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelBubbleSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelBubbleSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBubbleSort.Size = new System.Drawing.Size(259, 429);
            this.tableLayoutPanelBubbleSort.TabIndex = 3;
            // 
            // labelBubbleSortTimer
            // 
            this.labelBubbleSortTimer.AutoSize = true;
            this.labelBubbleSortTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBubbleSortTimer.Location = new System.Drawing.Point(3, 385);
            this.labelBubbleSortTimer.Name = "labelBubbleSortTimer";
            this.labelBubbleSortTimer.Size = new System.Drawing.Size(253, 44);
            this.labelBubbleSortTimer.TabIndex = 2;
            this.labelBubbleSortTimer.Text = "labelBubbleSortTimer";
            this.labelBubbleSortTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labeBubbleSort
            // 
            this.labeBubbleSort.AutoSize = true;
            this.labeBubbleSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeBubbleSort.Location = new System.Drawing.Point(3, 0);
            this.labeBubbleSort.Name = "labeBubbleSort";
            this.labeBubbleSort.Size = new System.Drawing.Size(253, 42);
            this.labeBubbleSort.TabIndex = 0;
            this.labeBubbleSort.Text = "Bubble Sort";
            this.labeBubbleSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewBubbleSort
            // 
            this.dataGridViewBubbleSort.AllowUserToAddRows = false;
            this.dataGridViewBubbleSort.AllowUserToDeleteRows = false;
            this.dataGridViewBubbleSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBubbleSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBubbleSort.Location = new System.Drawing.Point(3, 45);
            this.dataGridViewBubbleSort.Name = "dataGridViewBubbleSort";
            this.dataGridViewBubbleSort.ReadOnly = true;
            this.dataGridViewBubbleSort.RowHeadersWidth = 51;
            this.dataGridViewBubbleSort.RowTemplate.Height = 29;
            this.dataGridViewBubbleSort.Size = new System.Drawing.Size(253, 337);
            this.dataGridViewBubbleSort.TabIndex = 1;
            // 
            // tableLayoutQuickSort
            // 
            this.tableLayoutQuickSort.ColumnCount = 1;
            this.tableLayoutQuickSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutQuickSort.Controls.Add(this.labelQuickSortTimer, 0, 2);
            this.tableLayoutQuickSort.Controls.Add(this.labelQuickSort, 0, 0);
            this.tableLayoutQuickSort.Controls.Add(this.dataGridViewQuickSort, 0, 1);
            this.tableLayoutQuickSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutQuickSort.Location = new System.Drawing.Point(40, 157);
            this.tableLayoutQuickSort.Margin = new System.Windows.Forms.Padding(20);
            this.tableLayoutQuickSort.Name = "tableLayoutQuickSort";
            this.tableLayoutQuickSort.RowCount = 3;
            this.tableLayoutQuickSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutQuickSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutQuickSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutQuickSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutQuickSort.Size = new System.Drawing.Size(259, 429);
            this.tableLayoutQuickSort.TabIndex = 2;
            // 
            // labelQuickSortTimer
            // 
            this.labelQuickSortTimer.AutoSize = true;
            this.labelQuickSortTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQuickSortTimer.Location = new System.Drawing.Point(3, 385);
            this.labelQuickSortTimer.Name = "labelQuickSortTimer";
            this.labelQuickSortTimer.Size = new System.Drawing.Size(253, 44);
            this.labelQuickSortTimer.TabIndex = 2;
            this.labelQuickSortTimer.Text = "labelQuickSortTimer";
            this.labelQuickSortTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQuickSort
            // 
            this.labelQuickSort.AutoSize = true;
            this.labelQuickSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQuickSort.Location = new System.Drawing.Point(3, 0);
            this.labelQuickSort.Name = "labelQuickSort";
            this.labelQuickSort.Size = new System.Drawing.Size(253, 42);
            this.labelQuickSort.TabIndex = 0;
            this.labelQuickSort.Text = "Quick Sort";
            this.labelQuickSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewQuickSort
            // 
            this.dataGridViewQuickSort.AllowUserToAddRows = false;
            this.dataGridViewQuickSort.AllowUserToDeleteRows = false;
            this.dataGridViewQuickSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuickSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewQuickSort.Location = new System.Drawing.Point(3, 45);
            this.dataGridViewQuickSort.Name = "dataGridViewQuickSort";
            this.dataGridViewQuickSort.ReadOnly = true;
            this.dataGridViewQuickSort.RowHeadersWidth = 51;
            this.dataGridViewQuickSort.RowTemplate.Height = 29;
            this.dataGridViewQuickSort.Size = new System.Drawing.Size(253, 337);
            this.dataGridViewQuickSort.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 626);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.tableLayoutPanelGCFSort.ResumeLayout(false);
            this.tableLayoutPanelGCFSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGCFSort)).EndInit();
            this.tableLayoutPanelMergeSort.ResumeLayout(false);
            this.tableLayoutPanelMergeSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMergeSort)).EndInit();
            this.tableLayoutPanelBubbleSort.ResumeLayout(false);
            this.tableLayoutPanelBubbleSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBubbleSort)).EndInit();
            this.tableLayoutQuickSort.ResumeLayout(false);
            this.tableLayoutQuickSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuickSort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBoxInput;
        private Button buttonSort;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutQuickSort;
        private Label labelQuickSort;
        private DataGridView dataGridViewQuickSort;
        private Label labelQuickSortTimer;
        private TableLayoutPanel tableLayoutPanelGCFSort;
        private Label labelGCFSortTimer;
        private Label labelGCFSort;
        private DataGridView dataGridViewGCFSort;
        private TableLayoutPanel tableLayoutPanelMergeSort;
        private Label labelMergeSortTimer;
        private Label labelMergeSort;
        private DataGridView dataGridViewMergeSort;
        private TableLayoutPanel tableLayoutPanelBubbleSort;
        private Label labelBubbleSortTimer;
        private Label labeBubbleSort;
        private DataGridView dataGridViewBubbleSort;
    }
}