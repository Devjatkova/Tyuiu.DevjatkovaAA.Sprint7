using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.V2.Lib;
using System.IO;

namespace Project.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_DAA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_DAA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        DataService ds = new DataService();
        public static string path = @"C:\Users\ДНС\source\repos\Tyuiu.DevjatkovaAA.Sprint7\Project.V2\bin\Debug\DataBase.csv";

        // чтение файла
        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            //Разделение на строки
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            //Кол-во строк и столбцов
            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            //Новый массив
            string[,] arrayValues = new string[rows, columns];

            //Заполняем массив
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToString(line_r[c]);
                }
            }
            return arrayValues;
        }

        // вывод таблицы
        private void buttonOpenFile_DAA_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\ДНС\source\repos\Tyuiu.DevjatkovaAA.Sprint7\Project.V2\bin\Debug\DataBase.csv";

            string[,] arrayValues = new string[rows, columns];

            arrayValues = LoadFromFileData(path);

            dataGridViewMas_DAA.ColumnCount = columns;
            dataGridViewMas_DAA.RowCount = rows-1;

            dataGridViewRes_DAA.ColumnCount = columns;
            dataGridViewRes_DAA.RowCount = rows-1;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMas_DAA.Columns[i].Width = 80;
                dataGridViewRes_DAA.Columns[i].Width = 80;
            }
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == 0)
                    {
                        dataGridViewMas_DAA.Columns[j].HeaderCell.Value = arrayValues[i, j];
                        dataGridViewRes_DAA.Columns[j].HeaderCell.Value = arrayValues[i, j];
                    }
                    else
                    {
                        dataGridViewMas_DAA.Rows[i - 1].Cells[j].Value = arrayValues[i, j];
                    }
                }
            }
            this.dataGridViewMas_DAA.Rows.Add("", "", "", "", "", "", "");
            buttonSaveFile_DAA.Enabled = true;
            buttonAddRow_DAA.Enabled = true;
            buttonGraf_DAA.Enabled = true;
            buttonSearch_DAA.Enabled = true;
            buttonSort_DAA.Enabled = true;
            buttonStatRes_DAA.Enabled = true;
        }

        // сохранение файла
        private void buttonSaveFile_DAA_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_DAA.FileName = "DataBase.csv";
            saveFileDialogTask_DAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_DAA.ShowDialog();

            string path = saveFileDialogTask_DAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewMas_DAA.RowCount;
            int columns = dataGridViewMas_DAA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewMas_DAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewMas_DAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        // фильтрация по слову
        private void buttonSort_DAA_Click(object sender, EventArgs e)
        {
            int rows = dataGridViewMas_DAA.RowCount-1;
            int columns = dataGridViewMas_DAA.ColumnCount;
            int num = Convert.ToInt32(textBoxSortNum_DAA.Text);

            try
            {
                if (num >= 0 && num <= columns)
                {
                    if (num == 0)
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            dataGridViewMas_DAA.Rows[i].Visible = dataGridViewMas_DAA[0, i].Value.ToString() == textBoxSortWord_DAA.Text;
                        }
                    }
                    if (num == 1)
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            dataGridViewMas_DAA.Rows[i].Visible = dataGridViewMas_DAA[1, i].Value.ToString() == textBoxSortWord_DAA.Text;
                        }
                    }
                    if (num == 2)
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            dataGridViewMas_DAA.Rows[i].Visible = dataGridViewMas_DAA[2, i].Value.ToString() == textBoxSortWord_DAA.Text;
                        }
                    }
                    if (num == 3)
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            dataGridViewMas_DAA.Rows[i].Visible = dataGridViewMas_DAA[3, i].Value.ToString() == textBoxSortWord_DAA.Text;
                        }
                    }
                    if (num == 4)
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            dataGridViewMas_DAA.Rows[i].Visible = dataGridViewMas_DAA[4, i].Value.ToString() == textBoxSortWord_DAA.Text;
                        }
                    }
                    if (num == 5)
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            dataGridViewMas_DAA.Rows[i].Visible = dataGridViewMas_DAA[5, i].Value.ToString() == textBoxSortWord_DAA.Text;
                        }
                    }
                    if (num == 6)
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            dataGridViewMas_DAA.Rows[i].Visible = dataGridViewMas_DAA[6, i].Value.ToString() == textBoxSortWord_DAA.Text;
                        }
                    }
                    if (num == 7)
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            dataGridViewMas_DAA.Rows[i].Visible = dataGridViewMas_DAA[7, i].Value.ToString() == textBoxSortWord_DAA.Text;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // поиск
        private void buttonSearch_DAA_Click_1(object sender, EventArgs e)
        {
            try
            {
                string targetElement = Convert.ToString(textBoxSearch_DAA.Text);

                string[] arrayValues = new string[columns];
                arrayValues = ds.Search(LoadFromFileData(filePath: path), targetElement);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewRes_DAA.Rows[0].Cells[j].Value = arrayValues[j];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // добавить строку
        private void buttonAddRow_DAA_Click(object sender, EventArgs e)
        {
            this.dataGridViewMas_DAA.Rows.Add("", "", "", "", "", "", "");
        }

        // график
        private void buttonGraf_DAA_Click(object sender, EventArgs e)
        {
            this.chartGraf_DAA.ChartAreas[0].AxisX.Title = "Магазин";
            this.chartGraf_DAA.ChartAreas[0].AxisY.Title = "Оборот в млн руб.";

            chartGraf_DAA.Series[0].Points.Clear();

            for (int i = 0; i < rows; i++)
            {
                chartGraf_DAA.Series[0].Points.AddXY(dataGridViewMas_DAA.Rows[i].Cells[1].Value.ToString(), dataGridViewMas_DAA.Rows[i].Cells[5].Value.ToString());
            }
        }

        // статистика
        private void buttonStatRes_DAA_Click(object sender, EventArgs e)
        {
            try
            {
                string commandStat = Convert.ToString(comboBoxStatRes_DAA.Text);
                int columnIndex = 6;

                object[,] dataBase = new object[rows, columns];
                dataBase = LoadFromFileData(filePath: path);

                textBoxStatRes_DAA.Text = Convert.ToString(ds.DataStat(dataBase, commandStat, columnIndex));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // открытие форм
        private void buttonAboutProgram_DAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonHelp_DAA_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        // подсказки
        private void buttonOpenFile_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAA.ToolTipTitle = "Открыть файл";
        }

        private void buttonSaveFile_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAA.ToolTipTitle = "Сохранить файл";
        }

        private void buttonAboutProgram_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAA.ToolTipTitle = "Открыть информацию о разработчике";
        }

        private void buttonHelp_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAA.ToolTipTitle = "Краткое руководство пользователя";
        }

        private void buttonSort_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAA.ToolTipTitle = "Подсказка";
        }

        private void buttonSearch_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAA.ToolTipTitle = "Подсказка";
        }

        private void buttonAddRow_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAA.ToolTipTitle = "Подсказка";
        }

        private void buttonGraf_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAA.ToolTipTitle = "Подсказка";
        }

        private void buttonStatRes_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_DAA.ToolTipTitle = "Подсказка";
        }
    }
}
