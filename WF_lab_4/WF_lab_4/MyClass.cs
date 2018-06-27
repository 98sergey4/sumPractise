using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;


namespace WF_lab_4
{
    public class MyClass
    {
        public int N = 0, el;
        Form2 frm = new Form2();
        public int[][] mass;
        public void Genr(int n, int A, int B)
        {
            N = n;
            frm.dataGridView1.Rows.Clear();
            frm.dataGridView1.Columns.Clear();
            mass = new int[n][];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                mass[i] = new int[n];
                for (int j = 0; j < n; j++)
                    mass[i][j] = rand.Next(A, B);
            }
            frm.dataGridView1.Columns.Add("", ""); //отступы
            frm.dataGridView1.Columns[0].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable; //запрещаем сортировку
            int k = 0; //обнуляем к
            for (int i = 0; i < n; i++)
            {
                k = frm.dataGridView1.Rows.Add(); //получаем индекс

                string str = "x" + i.ToString(); //называем столбцы
                frm.dataGridView1.Columns.Add(str, str); //заполняем столбцы данными
                frm.dataGridView1.Columns[i + 1].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable; //запрещаем сортировку
                frm.dataGridView1.Rows[k].Cells[0].Value = "y" + k.ToString(); //заполняем столбцы данными

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    frm.dataGridView1.Rows[i].Cells[j + 1].Value = mass[i][j]; //заполняем стобцы числами
                    frm.dataGridView1.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
                    frm.dataGridView1.Columns[0].Resizable = System.Windows.Forms.DataGridViewTriState.True;
                }
            }
            frm.MD(N, A, B);
            frm.Show();
        }
        public void FirstMeth(int A, int B)
        {
            frm.dataGridView1.Rows.Clear();
            frm.dataGridView1.Columns.Clear();
            el = mass[0][0];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    if ((i + j) % 2 != 0)
                        if (el > mass[i][j])
                            el = mass[i][j];
                }
            frm.dataGridView1.Columns.Add("", ""); //отступы
            frm.dataGridView1.Columns[0].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable; //запрещаем сортировку
            int k = 0; //обнуляем к
            for (int i = 0; i < N; i++)
            {
                k = frm.dataGridView1.Rows.Add(); //получаем индекс

                string str = "x" + i.ToString(); //называем столбцы
                frm.dataGridView1.Columns.Add(str, str); //заполняем столбцы данными
                frm.dataGridView1.Columns[i + 1].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable; //запрещаем сортировку
                frm.dataGridView1.Rows[k].Cells[0].Value = "y" + k.ToString(); //заполняем столбцы данными

            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    frm.dataGridView1.Rows[i].Cells[j + 1].Value = mass[i][j]; //заполняем стобцы числами
                    frm.dataGridView1.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
                    frm.dataGridView1.Columns[0].Resizable = System.Windows.Forms.DataGridViewTriState.True;
                }
            }
            frm.textBox4.Text = Convert.ToString(el);
            frm.MD(N, A, B);
            frm.Show();
        }
        public void SecondMeth(int A, int B)
        {
            frm.dataGridView1.Rows.Clear();
            frm.dataGridView1.Columns.Clear();
            for (int i = 0; i < N; i++)
            {
                Array.Sort(mass[i], 0, N);
            }
            frm.dataGridView1.Columns.Add("", ""); //отступы
            frm.dataGridView1.Columns[0].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable; //запрещаем сортировку
            int k = 0; //обнуляем к
            for (int i = 0; i < N; i++)
            {
                k = frm.dataGridView1.Rows.Add(); //получаем индекс

                string str = "x" + i.ToString(); //называем столбцы
                frm.dataGridView1.Columns.Add(str, str); //заполняем столбцы данными
                frm.dataGridView1.Columns[i + 1].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable; //запрещаем сортировку
                frm.dataGridView1.Rows[k].Cells[0].Value = "y" + k.ToString(); //заполняем столбцы данными

            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    frm.dataGridView1.Rows[i].Cells[j + 1].Value = mass[i][j]; //заполняем стобцы числами
                    frm.dataGridView1.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
                    frm.dataGridView1.Columns[0].Resizable = System.Windows.Forms.DataGridViewTriState.True;
                }
            }
            frm.MD(N, A, B);
            frm.Show();

        }
        public void ThrithMeth(int A, int B, int t)
        {
            frm.dataGridView1.Rows.Clear();
            frm.dataGridView1.Columns.Clear();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    if (mass[i][j] % 2 == 0)
                        mass[i][j] = mass[i][j] * (-t);

            frm.dataGridView1.Columns.Add("", ""); //отступы
            frm.dataGridView1.Columns[0].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable; //запрещаем сортировку
            int k = 0; //обнуляем к
            for (int i = 0; i < N; i++)
            {
                k = frm.dataGridView1.Rows.Add(); //получаем индекс

                string str = "x" + i.ToString(); //называем столбцы
                frm.dataGridView1.Columns.Add(str, str); //заполняем столбцы данными
                frm.dataGridView1.Columns[i + 1].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable; //запрещаем сортировку
                frm.dataGridView1.Rows[k].Cells[0].Value = "y" + k.ToString(); //заполняем столбцы данными

            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    frm.dataGridView1.Rows[i].Cells[j + 1].Value = mass[i][j]; //заполняем стобцы числами
                    frm.dataGridView1.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
                    frm.dataGridView1.Columns[0].Resizable = System.Windows.Forms.DataGridViewTriState.True;
                }
            }
            frm.MD(N, A, B);
            frm.Show();
        }
        public void SaveMass()
        {
            if (mass == null) //если массив пустой - выходим 
                return;
            SaveFileDialog my_save_FileDialog = new SaveFileDialog() //создание экземпляра диалога 
            {
                InitialDirectory = "C:\\Users\\VAdiM\\Desktop", //стандартный путь 
                Filter = "json files (*.json)|*.json|All files (*.*)|*.*", //фильтр 
                RestoreDirectory = true //запоминает где в прошлый раз закрыто было окно диалога 
            };
            if (my_save_FileDialog.ShowDialog() == DialogResult.OK) //если открыто успешно - выполняем 
            {
                FileStream file = new FileStream(my_save_FileDialog.FileName, FileMode.Create, FileAccess.Write); //создание потока 
                DataContractJsonSerializer mySerializ = new DataContractJsonSerializer(typeof(int[][])); //сериализуем объект типа массивов массивов 
                mySerializ.WriteObject(file, mass); //записываем объект в файл 
                file.Close(); //закрываем поток 
            }
        }
        public void Load()
        {
            try
            {
                OpenFileDialog my_open_FileDialog = new OpenFileDialog() //создание экземпляра диалога 
                {
                    InitialDirectory = "C:\\Users\\VAdiM\\Desktop", //стандартный путь 
                    Filter = "json files (*.json)|*.json|All files (*.*)|*.*", //фильтр 
                    RestoreDirectory = true //запоминает где в прошлый раз закрыто было окно диалога 
                };
                if (my_open_FileDialog.ShowDialog() == DialogResult.OK) //если открыто успешно - выполняем 
                {
                    FileStream file = new FileStream(my_open_FileDialog.FileName, FileMode.Open, FileAccess.Read); //создание потока 
                    DataContractJsonSerializer mySerializ = new DataContractJsonSerializer(typeof(int[][])); //сериализуем объект типа массив массивов 
                    mass = (int[][])mySerializ.ReadObject(file); //записываем объект в массив 
                    file.Close(); //закрываем поток 
                    N = mass.Length; //сохраняем размер массива 
                    frm.textBox1.Text = Convert.ToString(N); //запимываем данные в форму 2 
                    frm.dataGridView1.Rows.Clear(); //очищаем grid 
                    frm.dataGridView1.Columns.Clear();
                    frm.dataGridView1.Columns.Add("", ""); //добавляем место 
                    frm.dataGridView1.Columns[0].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable; //запрещаем сортировать 
                    int k = 0;
                    for (int i = 0; i < N; i++)
                    {
                        k = frm.dataGridView1.Rows.Add(); //запоминаем индекс 

                        string str = "x" + i.ToString(); //заполняем полями х 
                        frm.dataGridView1.Columns.Add(str, str);
                        frm.dataGridView1.Columns[i + 1].SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable; //запрещаем сортировать 
                        frm.dataGridView1.Rows[k].Cells[0].Value = "y" + k.ToString(); //заполняем полями y 

                    }
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            frm.dataGridView1.Rows[i].Cells[j + 1].Value = mass[i][j]; //заполяем данными 
                            frm.dataGridView1.Columns[0].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
                            frm.dataGridView1.Columns[0].Resizable = System.Windows.Forms.DataGridViewTriState.True;
                        }
                    }
                    frm.Show(); //вызываем вторую форму 
                }
            }
            catch
            {
                MessageBox.Show("Выберите корректный .json файл"); //если ошибка 
            }
            frm.Show();
        }
    }
}
