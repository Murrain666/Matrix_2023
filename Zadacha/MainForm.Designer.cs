namespace Zadacha
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalcParallButton = new System.Windows.Forms.Button();
            this.ParallResultLabel = new System.Windows.Forms.Label();
            this.MatrixADataGridView = new System.Windows.Forms.DataGridView();
            this.MatrixBDataGridView = new System.Windows.Forms.DataGridView();
            this.MatrixResultDataGridView = new System.Windows.Forms.DataGridView();
            this.RowALabel = new System.Windows.Forms.Label();
            this.ColALabel = new System.Windows.Forms.Label();
            this.ColBLabel = new System.Windows.Forms.Label();
            this.RowBLabel = new System.Windows.Forms.Label();
            this.SequentialLabel = new System.Windows.Forms.Label();
            this.MatrixALabel = new System.Windows.Forms.Label();
            this.MatrixBLabel = new System.Windows.Forms.Label();
            this.MatrixResultLabel = new System.Windows.Forms.Label();
            this.ParallLabel = new System.Windows.Forms.Label();
            this.FillMatrixButton = new System.Windows.Forms.Button();
            this.RowANumeric = new System.Windows.Forms.NumericUpDown();
            this.RowBNumeric = new System.Windows.Forms.NumericUpDown();
            this.ColANumeric = new System.Windows.Forms.NumericUpDown();
            this.ColBNumeric = new System.Windows.Forms.NumericUpDown();
            this.SequentialResultLabel = new System.Windows.Forms.Label();
            this.CalcSequentialButton = new System.Windows.Forms.Button();
            this.ResultButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixResultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowANumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowBNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColANumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColBNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // CalcParallButton
            // 
            this.CalcParallButton.Enabled = false;
            this.CalcParallButton.Location = new System.Drawing.Point(702, 204);
            this.CalcParallButton.Name = "CalcParallButton";
            this.CalcParallButton.Size = new System.Drawing.Size(132, 44);
            this.CalcParallButton.TabIndex = 0;
            this.CalcParallButton.Text = "Вычислить (параллельно)";
            this.CalcParallButton.UseVisualStyleBackColor = true;
            this.CalcParallButton.Click += new System.EventHandler(this.CalcParallButton_Click);
            // 
            // ParallResultLabel
            // 
            this.ParallResultLabel.AutoSize = true;
            this.ParallResultLabel.Location = new System.Drawing.Point(294, 204);
            this.ParallResultLabel.Name = "ParallResultLabel";
            this.ParallResultLabel.Size = new System.Drawing.Size(174, 16);
            this.ParallResultLabel.TabIndex = 5;
            this.ParallResultLabel.Text = "результат (параллельно)";
            // 
            // MatrixADataGridView
            // 
            this.MatrixADataGridView.AllowUserToAddRows = false;
            this.MatrixADataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MatrixADataGridView.ColumnHeadersHeight = 29;
            this.MatrixADataGridView.ColumnHeadersVisible = false;
            this.MatrixADataGridView.Location = new System.Drawing.Point(405, 37);
            this.MatrixADataGridView.Name = "MatrixADataGridView";
            this.MatrixADataGridView.RowHeadersVisible = false;
            this.MatrixADataGridView.RowHeadersWidth = 51;
            this.MatrixADataGridView.RowTemplate.Height = 24;
            this.MatrixADataGridView.Size = new System.Drawing.Size(240, 150);
            this.MatrixADataGridView.TabIndex = 6;
            // 
            // MatrixBDataGridView
            // 
            this.MatrixBDataGridView.AllowUserToAddRows = false;
            this.MatrixBDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MatrixBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixBDataGridView.ColumnHeadersVisible = false;
            this.MatrixBDataGridView.Location = new System.Drawing.Point(670, 37);
            this.MatrixBDataGridView.Name = "MatrixBDataGridView";
            this.MatrixBDataGridView.RowHeadersVisible = false;
            this.MatrixBDataGridView.RowHeadersWidth = 51;
            this.MatrixBDataGridView.RowTemplate.Height = 24;
            this.MatrixBDataGridView.Size = new System.Drawing.Size(240, 150);
            this.MatrixBDataGridView.TabIndex = 7;
            // 
            // MatrixResultDataGridView
            // 
            this.MatrixResultDataGridView.AllowUserToAddRows = false;
            this.MatrixResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MatrixResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixResultDataGridView.ColumnHeadersVisible = false;
            this.MatrixResultDataGridView.Location = new System.Drawing.Point(934, 37);
            this.MatrixResultDataGridView.Name = "MatrixResultDataGridView";
            this.MatrixResultDataGridView.RowHeadersVisible = false;
            this.MatrixResultDataGridView.RowHeadersWidth = 51;
            this.MatrixResultDataGridView.RowTemplate.Height = 24;
            this.MatrixResultDataGridView.Size = new System.Drawing.Size(240, 150);
            this.MatrixResultDataGridView.TabIndex = 8;
            // 
            // RowALabel
            // 
            this.RowALabel.AutoSize = true;
            this.RowALabel.Location = new System.Drawing.Point(12, 26);
            this.RowALabel.Name = "RowALabel";
            this.RowALabel.Size = new System.Drawing.Size(207, 16);
            this.RowALabel.TabIndex = 9;
            this.RowALabel.Text = "Количество строк в матрице А";
            // 
            // ColALabel
            // 
            this.ColALabel.AutoSize = true;
            this.ColALabel.Location = new System.Drawing.Point(12, 57);
            this.ColALabel.Name = "ColALabel";
            this.ColALabel.Size = new System.Drawing.Size(232, 16);
            this.ColALabel.TabIndex = 10;
            this.ColALabel.Text = "Количество столбцов в матрице А";
            // 
            // ColBLabel
            // 
            this.ColBLabel.AutoSize = true;
            this.ColBLabel.Location = new System.Drawing.Point(12, 142);
            this.ColBLabel.Name = "ColBLabel";
            this.ColBLabel.Size = new System.Drawing.Size(232, 16);
            this.ColBLabel.TabIndex = 12;
            this.ColBLabel.Text = "Количество столбцов в матрице B";
            // 
            // RowBLabel
            // 
            this.RowBLabel.AutoSize = true;
            this.RowBLabel.Location = new System.Drawing.Point(12, 111);
            this.RowBLabel.Name = "RowBLabel";
            this.RowBLabel.Size = new System.Drawing.Size(207, 16);
            this.RowBLabel.TabIndex = 11;
            this.RowBLabel.Text = "Количество строк в матрице B";
            // 
            // SequentialLabel
            // 
            this.SequentialLabel.AutoSize = true;
            this.SequentialLabel.Location = new System.Drawing.Point(12, 225);
            this.SequentialLabel.Name = "SequentialLabel";
            this.SequentialLabel.Size = new System.Drawing.Size(293, 16);
            this.SequentialLabel.TabIndex = 13;
            this.SequentialLabel.Text = "Результат последовательного вычисления";
            // 
            // MatrixALabel
            // 
            this.MatrixALabel.AutoSize = true;
            this.MatrixALabel.Location = new System.Drawing.Point(490, 9);
            this.MatrixALabel.Name = "MatrixALabel";
            this.MatrixALabel.Size = new System.Drawing.Size(77, 16);
            this.MatrixALabel.TabIndex = 14;
            this.MatrixALabel.Text = "Матрица А";
            // 
            // MatrixBLabel
            // 
            this.MatrixBLabel.AutoSize = true;
            this.MatrixBLabel.Location = new System.Drawing.Point(757, 9);
            this.MatrixBLabel.Name = "MatrixBLabel";
            this.MatrixBLabel.Size = new System.Drawing.Size(77, 16);
            this.MatrixBLabel.TabIndex = 15;
            this.MatrixBLabel.Text = "Матрица В";
            // 
            // MatrixResultLabel
            // 
            this.MatrixResultLabel.AutoSize = true;
            this.MatrixResultLabel.Location = new System.Drawing.Point(1024, 9);
            this.MatrixResultLabel.Name = "MatrixResultLabel";
            this.MatrixResultLabel.Size = new System.Drawing.Size(77, 16);
            this.MatrixResultLabel.TabIndex = 16;
            this.MatrixResultLabel.Text = "Результат";
            // 
            // ParallLabel
            // 
            this.ParallLabel.AutoSize = true;
            this.ParallLabel.Location = new System.Drawing.Point(12, 204);
            this.ParallLabel.Name = "ParallLabel";
            this.ParallLabel.Size = new System.Drawing.Size(263, 16);
            this.ParallLabel.TabIndex = 17;
            this.ParallLabel.Text = "Результат параллельного вычисления";
            // 
            // FillMatrixButton
            // 
            this.FillMatrixButton.Location = new System.Drawing.Point(564, 204);
            this.FillMatrixButton.Name = "FillMatrixButton";
            this.FillMatrixButton.Size = new System.Drawing.Size(132, 44);
            this.FillMatrixButton.TabIndex = 18;
            this.FillMatrixButton.Text = "Заполнить матрицы";
            this.FillMatrixButton.UseVisualStyleBackColor = true;
            this.FillMatrixButton.Click += new System.EventHandler(this.FillMatrixButton_Click);
            // 
            // RowANumeric
            // 
            this.RowANumeric.Location = new System.Drawing.Point(266, 24);
            this.RowANumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RowANumeric.Name = "RowANumeric";
            this.RowANumeric.Size = new System.Drawing.Size(120, 22);
            this.RowANumeric.TabIndex = 19;
            this.RowANumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // RowBNumeric
            // 
            this.RowBNumeric.Location = new System.Drawing.Point(266, 109);
            this.RowBNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RowBNumeric.Name = "RowBNumeric";
            this.RowBNumeric.Size = new System.Drawing.Size(120, 22);
            this.RowBNumeric.TabIndex = 20;
            this.RowBNumeric.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // ColANumeric
            // 
            this.ColANumeric.Location = new System.Drawing.Point(266, 55);
            this.ColANumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ColANumeric.Name = "ColANumeric";
            this.ColANumeric.Size = new System.Drawing.Size(120, 22);
            this.ColANumeric.TabIndex = 21;
            this.ColANumeric.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // ColBNumeric
            // 
            this.ColBNumeric.Location = new System.Drawing.Point(266, 140);
            this.ColBNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ColBNumeric.Name = "ColBNumeric";
            this.ColBNumeric.Size = new System.Drawing.Size(120, 22);
            this.ColBNumeric.TabIndex = 22;
            this.ColBNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // SequentialResultLabel
            // 
            this.SequentialResultLabel.AutoSize = true;
            this.SequentialResultLabel.Location = new System.Drawing.Point(326, 225);
            this.SequentialResultLabel.Name = "SequentialResultLabel";
            this.SequentialResultLabel.Size = new System.Drawing.Size(174, 16);
            this.SequentialResultLabel.TabIndex = 23;
            this.SequentialResultLabel.Text = "результат (параллельно)";
            // 
            // CalcSequentialButton
            // 
            this.CalcSequentialButton.Enabled = false;
            this.CalcSequentialButton.Location = new System.Drawing.Point(840, 204);
            this.CalcSequentialButton.Name = "CalcSequentialButton";
            this.CalcSequentialButton.Size = new System.Drawing.Size(145, 44);
            this.CalcSequentialButton.TabIndex = 24;
            this.CalcSequentialButton.Text = "Вычислить (последовательно)";
            this.CalcSequentialButton.UseVisualStyleBackColor = true;
            this.CalcSequentialButton.Click += new System.EventHandler(this.CalcSequentialButton_Click);
            // 
            // ResultButton
            // 
            this.ResultButton.Enabled = false;
            this.ResultButton.Location = new System.Drawing.Point(991, 204);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(132, 44);
            this.ResultButton.TabIndex = 25;
            this.ResultButton.Text = "Результат";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 258);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.CalcSequentialButton);
            this.Controls.Add(this.SequentialResultLabel);
            this.Controls.Add(this.ColBNumeric);
            this.Controls.Add(this.ColANumeric);
            this.Controls.Add(this.RowBNumeric);
            this.Controls.Add(this.RowANumeric);
            this.Controls.Add(this.FillMatrixButton);
            this.Controls.Add(this.ParallLabel);
            this.Controls.Add(this.MatrixResultLabel);
            this.Controls.Add(this.MatrixBLabel);
            this.Controls.Add(this.MatrixALabel);
            this.Controls.Add(this.SequentialLabel);
            this.Controls.Add(this.ColBLabel);
            this.Controls.Add(this.RowBLabel);
            this.Controls.Add(this.ColALabel);
            this.Controls.Add(this.RowALabel);
            this.Controls.Add(this.MatrixResultDataGridView);
            this.Controls.Add(this.MatrixBDataGridView);
            this.Controls.Add(this.MatrixADataGridView);
            this.Controls.Add(this.ParallResultLabel);
            this.Controls.Add(this.CalcParallButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Перемножение матриц";
            ((System.ComponentModel.ISupportInitialize)(this.MatrixADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixResultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowANumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowBNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColANumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColBNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcParallButton;
        private System.Windows.Forms.Label ParallResultLabel;
        private System.Windows.Forms.DataGridView MatrixADataGridView;
        private System.Windows.Forms.DataGridView MatrixBDataGridView;
        private System.Windows.Forms.DataGridView MatrixResultDataGridView;
        private System.Windows.Forms.Label RowALabel;
        private System.Windows.Forms.Label ColALabel;
        private System.Windows.Forms.Label ColBLabel;
        private System.Windows.Forms.Label RowBLabel;
        private System.Windows.Forms.Label SequentialLabel;
        private System.Windows.Forms.Label MatrixALabel;
        private System.Windows.Forms.Label MatrixBLabel;
        private System.Windows.Forms.Label MatrixResultLabel;
        private System.Windows.Forms.Label ParallLabel;
        private System.Windows.Forms.Button FillMatrixButton;
        private System.Windows.Forms.NumericUpDown RowANumeric;
        private System.Windows.Forms.NumericUpDown RowBNumeric;
        private System.Windows.Forms.NumericUpDown ColANumeric;
        private System.Windows.Forms.NumericUpDown ColBNumeric;
        private System.Windows.Forms.Label SequentialResultLabel;
        private System.Windows.Forms.Button CalcSequentialButton;
        private System.Windows.Forms.Button ResultButton;
    }
}

