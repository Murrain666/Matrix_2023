using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Массив матрицы А.
        /// </summary>
        private int[,] matrixA;

        /// <summary>
        /// Массив матрицы В.
        /// </summary>
        private int[,] matrixB;

        /// <summary>
        /// Массив результирующей матрицы.
        /// </summary>
        private int[,] resultMatrix;

        /// <summary>
        /// Строка матрицы А, строка матрицы В, столбец матрицы А, столбец матрицы В.
        /// </summary>
        private int rowA = 0, rowB = 0, colA = 0, colB = 0;

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод параллельного вычисления.
        /// </summary>
        private void ParalCalc()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Parallel.For(0, rowA, i =>
            {
                for (int j = 0; j < colB; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < colA; k++)
                    {
                        sum += matrixA[i, k] * matrixB[k, j];
                    }
                    resultMatrix[i, j] = sum;
                }
            });
            stopwatch.Stop();

            ParallResultLabel.Text = "затрачено времени: "
                + stopwatch.Elapsed.TotalMilliseconds.ToString() + " мс";
        }

        /// <summary>
        /// Метод последовательного вычисления.
        /// </summary>
        private void SequentialCalc()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < rowA; i++)
            {
                for (int j = 0; j < colB; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < colA; k++)
                    {
                        sum += matrixA[i, k] * matrixB[k, j];
                    }
                    resultMatrix[i, j] = sum;
                }
            }
            stopwatch.Stop();

            SequentialResultLabel.Text = "затрачено времени: "
                + stopwatch.Elapsed.TotalMilliseconds.ToString() + " мс";
        }


        /// <summary>
        /// Событие при нажатии на кнопку Вычислить (параллельно).
        /// </summary>
        private void CalcParallButton_Click(object sender, EventArgs e)
        {
            ParalCalc();
        }

        /// <summary>
        /// Событие при нажатии на кнопку Результат.
        /// </summary>
        private void ResultButton_Click(object sender, EventArgs e)
        {
            PrintResult();
        }

        /// <summary>
        /// Событие при нажатии на кнопку Вычислить (последовательно).
        /// </summary>
        private void CalcSequentialButton_Click(object sender, EventArgs e)
        {
            SequentialCalc();
        }

        /// <summary>
        /// Событие заполнения матриц А и матриц В.
        /// </summary>
        private void FillMatrixButton_Click(object sender, EventArgs e)
        {
            FillMatrix();
            CalcParallButton.Enabled = true;
            CalcSequentialButton.Enabled = true;
            ResultButton.Enabled = true;
        }

        /// <summary>
        /// Метод заполнения матриц.
        /// </summary>
        private void FillMatrix()
        {
            MatrixADataGridView.Rows.Clear();
            MatrixADataGridView.Columns.Clear();
            MatrixBDataGridView.Rows.Clear();
            MatrixBDataGridView.Columns.Clear();

            rowA = int.Parse(RowANumeric.Value.ToString());
            colA = int.Parse(ColANumeric.Value.ToString());
            rowB = int.Parse(RowBNumeric.Value.ToString());
            colB = int.Parse(ColBNumeric.Value.ToString());

            if (colA != rowB)
            {
                MessageBox.Show("Количество столбцов в первой матрице " +
                    "должно быть равно количеству строк во второй матрице.");
                return;
            }

            matrixA = new int[rowA, colA];
            matrixB = new int[rowB, colB];
            resultMatrix = new int[rowA, colB];

            Random rand = new Random();

            for (int i = 0; i < rowA; i++)
            {
                for (int j = 0; j < colA; j++)
                {
                    matrixA[i, j] = rand.Next(10);
                }
            }

            for (int i = 0; i < rowB; i++)
            {
                for (int j = 0; j < colB; j++)
                {
                    matrixB[i, j] = rand.Next(10);
                }
            }

            MatrixADataGridView.ColumnCount = colA;
            MatrixBDataGridView.ColumnCount = colB;

            for (int i = 0; i < rowA; i++)
            {
                MatrixADataGridView.Rows.Add();
                for (int j = 0; j < colA; j++)
                {
                    MatrixADataGridView.Rows[i].Cells[j].Value = matrixA[i, j];
                }
            }

            for (int i = 0; i < rowB; i++)
            {
                MatrixBDataGridView.Rows.Add();
                for (int j = 0; j < colB; j++)
                {
                    MatrixBDataGridView.Rows[i].Cells[j].Value = matrixB[i, j];
                }
            }
        }

        /// <summary>
        /// Метод вывода информации.
        /// </summary>
        private void PrintResult()
        {
            MatrixResultDataGridView.ColumnCount = colB;
            MatrixResultDataGridView.RowCount = rowA;

            for (int i = 0; i < rowA; i++)
            {
                MatrixResultDataGridView.Rows.Add();
                for (int j = 0; j < colB; j++)
                {
                    MatrixResultDataGridView.Rows[i].Cells[j].Value = resultMatrix[i, j];
                }
            }
        }
    }
}