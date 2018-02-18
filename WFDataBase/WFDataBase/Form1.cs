//Ермолаев Сергей
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace WFDataBase
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        DataSet ds;
        SqlDataAdapter adapter;

        string filename;

        public Form1()
        {
            InitializeComponent();
        }

        //Функция записи события в лог файл
        private void WriteLogFile(string eventUser)
        {
            string path = "log.txt";
            StreamWriter sw = new StreamWriter(path,true);
            sw.WriteLine(eventUser + "  -  " + DateTime.Now);
            sw.WriteLine("---------------------------------");
            sw.Close();
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filename = openFileDialog1.FileName;

            connectBD();
        }

        private void connectBD()
        {
            string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=" + filename  +";Integrated Security=True";

            try
            {
                sqlConnection = new SqlConnection(connectString);
                sqlConnection.Open();
                WriteLogFile("Подключение базы данных");
                ToolsStripMenuItem.Enabled = true;
            }
            catch
            {
                MessageBox.Show("БД не подключена");
            }

        }

        //Создание трех таблиц
        private async void CreateTableBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {

                string querty = "CREATE TABLE Table" + (i + 1).ToString() +
                                " ([Id] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY," +
                                "[DateRnd] DATE NULL," +
                                "[NumberInt] INT NULL," +
                                "[NumberFloat] FLOAT NULL," +
                                "[TextStr] NCHAR(50) NULL )";

                SqlCommand command = new SqlCommand(querty, sqlConnection);

                try
                {
                    await command.ExecuteNonQueryAsync();
                    WriteLogFile("Создание таблицы Table" + (i+1).ToString());
                }
                catch
                {
                    WriteLogFile("Не удалось создать Table" + (i + 1).ToString());
                    MessageBox.Show("Table" + (i + 1).ToString() + " есть в БД");
                }

            }         
        }

        //Заполнение таблиц
        private  void FillTableBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            //Рандомная дата
            Random gen = new Random();
            DateTime DateRnd = new DateTime(1993,01,01);
            int range = (DateTime.Today - DateRnd).Days;

            //Рандомное целое число
            int NumberInt;

            //Рандомное число с плавающей точкой
            double NumberFloat;

            //Рандомный текст
            string TextStr = "";

            for (int tab = 1; tab < 4; tab++)
            {
                try               {
                    for (int i = 0; i < 5; i++)
                    {
                        DateRnd = DateRnd.AddDays(gen.Next(range));
                        NumberInt = gen.Next(0, 100);
                        NumberFloat = Math.Round(gen.NextDouble() * (1 - 0) + 0, 3);
                        for (var j = 0; j < 7; j++)
                        {
                            TextStr += Convert.ToChar(gen.Next('A', 'Z' + 1));
                        }

                        SqlCommand command = new SqlCommand("INSERT INTO [Table" + tab.ToString() + "] (DateRnd,NumberInt,NumberFloat,TextStr) VALUES (@DateRnd, @NumberInt, @NumberFloat, @TextStr)", sqlConnection);

                        command.Parameters.AddWithValue("DateRnd", DateRnd);
                        command.Parameters.AddWithValue("NumberInt", NumberInt);
                        command.Parameters.AddWithValue("NumberFloat", NumberFloat);
                        command.Parameters.AddWithValue("TextStr", TextStr);

                        command.ExecuteNonQuery();               

                        TextStr = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Неудачная попытка заполнения таблицы Table" + (tab + 1).ToString());
                    WriteLogFile("Неудачная попытка заполнения таблицы Table" + (tab + 1).ToString());
                }
            }
        }

        //Обработчик загрузки формы
        private void Form1_Load(object sender, EventArgs e)
        {
            WriteLogFile("Запуск приложения");
        }

        //Показать данные в таблицы
        private void ShowDateTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Вызываем метод для отображения данных из таблиц БД в DataGridView
            ShowDataGridView(dataGridView1, 1);
            ShowDataGridView(dataGridView2, 2);
            ShowDataGridView(dataGridView3, 3);
        }

        //Показываем данные из базы данных в DataGridView
        private void ShowDataGridView(DataGridView dataGridView, int i)
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM [Table" + i.ToString() + "]", sqlConnection);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView.DataSource = ds.Tables[0];
                dataGridView.Columns["Id"].ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Не удалалось показать таблицу Table" + i.ToString());
            }
        }


        //Запрос с объединением таблиц по ключевому полю
        private void QueryJoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM [Table1] INNER JOIN [Table2] ON [Table1].Id=[Table2].Id  ", sqlConnection);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView4.DataSource = ds.Tables[0].DefaultView;
        }

        //Обработчик события закрытия формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            WriteLogFile("Выход из приложения");
        }

        //Запрос с объединением таблиц по ключевому полю и выводом определенных полей
        private void buttonRunQuery1_Click(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT [Table1].Id, [Table1].DateRnd, [Table2].DateRnd, [Table1].NumberInt, [Table2].NumberInt FROM [Table1] INNER JOIN [Table2] ON [Table1].Id=[Table2].Id  ", sqlConnection);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView4.DataSource = ds.Tables[0];

            WriteLogFile("Выполнен запрос по ключевому полю");
        }

        //Запрос с сортровкой
        private void buttonRunQuery2_Click(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT [Table1].Id, [Table1].DateRnd, [Table2].DateRnd, [Table1].NumberInt, [Table2].NumberInt FROM [Table1] INNER JOIN [Table2] ON [Table1].Id=[Table2].Id ORDER BY [Table2].DateRnd   ", sqlConnection);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView4.DataSource = ds.Tables[0];

            WriteLogFile("Выполнен запрос с сортировкой");
        }


        //Запрос с фильтром
        private void buttonRunQuery3_Click(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT [Table1].Id, [Table1].DateRnd, [Table2].DateRnd, [Table1].NumberInt, [Table2].NumberInt " +
                "FROM [Table1] " +
                "INNER JOIN [Table2] ON [Table1].Id=[Table2].Id " +
                "WHERE  ([Table1].NumberInt > 50) AND ([Table2].NumberInt > 50)  ", sqlConnection);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView4.DataSource = ds.Tables[0];

            WriteLogFile("Выполнен запрос с фильтром");
        }


        //Сохранить в excel 
        private void SaveFileXlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Выибраем диркторию и имя
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filenameSave = saveFileDialog1.FileName;

            //Создаем объекты приложения, книги, листа
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelworkSheet;

            //Создаем саму книгу
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);

            //Создаем лист в книги
            ExcelworkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            //Заполняем лист
            for (int j = 0; j < dataGridView4.Columns.Count; j++)
            {
                //Заголовки таблиц
                ExcelApp.Cells[1, j + 1] = dataGridView4.Columns[j].HeaderCell.Value;
                for (int i = 0; i < dataGridView4.Rows.Count; i++)
                {
                    //Данные из таблицы
                    ExcelApp.Cells[i + 2, j + 1] = dataGridView4.Rows[i].Cells[j].Value;
                }
            }

            //Сохраняем или заменяем существующий файл
            ExcelWorkBook.SaveAs(filenameSave);

            //Закрываем
            ExcelWorkBook.Close();
            ExcelApp.Quit();

            WriteLogFile("Сохранение данных в файл " + filenameSave);

        }

        //Сохранить в .csv
        private void SaveFileCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Спрашиваем название и путь к файлу
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filenameSave = saveFileDialog1.FileName;

            //Определим создаем ли мы новый файл или перезаписываем существующий
            //Делаем это для  того, что бы в конце добавлять или нет расширение файла (.csv)
            string formatFile = "";
            for (int a = 4; a > 0; a--)
            {
               formatFile += filenameSave[(filenameSave.Length)-a].ToString();
            }

            StreamWriter sw;

            if (formatFile != ".csv")
            {
                sw = new StreamWriter(filenameSave + ".csv");
            }
            else
            {
                sw = new StreamWriter(filenameSave);
            }

            for (int i = -1; i < dataGridView4.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView4.Columns.Count; j++)
                {
                    if (i == -1)
                    {
                        sw.Write(dataGridView4.Columns[j].HeaderCell.Value+";");
                    }
                    else
                    {
                        sw.Write(dataGridView4.Rows[i].Cells[j].Value+";");
                    }
                }
                sw.WriteLine();
            }

            sw.Close();

            WriteLogFile("Сохранение данных в файл" + filenameSave);
        }
    }
}
