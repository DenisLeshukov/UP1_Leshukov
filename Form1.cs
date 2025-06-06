using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UP1_Leshukov
{
    public partial class Form1 : Form
    {
        List<string> song_text = new List<string>();
        private Dictionary<string, int> Basket = new Dictionary<string, int>();
        List<string> names = new List<string>();
        Playlist playlist = new Playlist();
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridViewPlaylist();
        }
        Shop pyaterochka = new Shop();




        private void showEl()//Показать все товары в магазине
        {
            listBox1.Items.Clear();
            string q = pyaterochka.WriteAllProducts();
            string[] s = q.Split('\n');
            for (int i = 0; i < s.Length; i++)
            {
                listBox1.Items.Add(s[i]);
            }

            listBox1.Items.Add($"Прибыль магазина {pyaterochka.GetProf()}");//Вывод прибыли магазина
        }

        private void Введение_Базовый_Данных(object sender, EventArgs e)
        {
            pyaterochka.CreateProduct("Кола", 85, 200);
            pyaterochka.CreateProduct("Сок \"Добрый\"", 100, 50);
            showEl();
        }

        private void Добавить_в_Корзину(object sender, EventArgs e)
        {
            if (textBox1.Text != "")//Проверка на пустое имя товара
            {
                string name = textBox1.Text;
                int count = Convert.ToInt32(numericUpDown1.Value);
                if (Basket.ContainsKey(name))
                {
                    MessageBox.Show("Товар уже добавлен");
                }
                else
                {
                    if (pyaterochka.CheckforCount(name, count))
                    {
                        listBox2.Items.Add($"{name} {count}");
                        names.Add(name);
                        Basket.Add(name, count);
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите имя товара");
            }
        }

        private void Показать_все_элементы(object sender, EventArgs e)
        {
            showEl();
            listBox1.Items.Add($"Прибыль магазина {pyaterochka.GetProf()}");

        }

        private void Добавить_Товар(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                string name = textBox2.Text;
                int count = Convert.ToInt32(numericUpDown2.Value);
                int price = Convert.ToInt32(numericUpDown3.Value);
                if (pyaterochka.FindByName(name) == null)//Проверка на наличие товара
                {
                    pyaterochka.CreateProduct(name, price, count);//Создание продукта
                    pyaterochka.ProfitCount(price, count, 10);//Подсчёт трат на этот продукт
                    showEl();

                }
                else
                {
                    MessageBox.Show("Такой товар уже есть");
                }
            }
            else
            {
                MessageBox.Show("Введите имя товара");
            }
        }

        private void Продать_Товары(object sender, EventArgs e)
        {
            for (int i = 0; i < names.Count; i++)
            {
                pyaterochka.Sell(names[i], Basket[names[i]]);
            }
            listBox2.Items.Clear();
            showEl();
        }

        private void Прейти_ко_2й_практике(object sender, EventArgs e)
        {
            panel2.Visible = false;//Спрятать третье задание
            panel1.Visible = true;//Показать все элементы относящиеся ко 2й практике
        }

        private void Пререйти_к_3й_практике(object sender, EventArgs e)
        {
            panel2.Visible = true;//Показать все элементы относящиеся ко 2й практике
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //3
        private void InitializeDataGridViewPlaylist()
        {
            // Устанавливаем количество колонок в DataGridView
            dataGridView1.ColumnCount = 3;

            // Называем колонки таблицы
            dataGridView1.Columns[0].Name = "Автор";       // Автор песни
            dataGridView1.Columns[1].Name = "Название";     // Название песни
            dataGridView1.Columns[2].Name = "Название файла"; // Имя файла с песней

            // Автоматически растягиваем все колонки по ширине таблицы
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void CompletionDGVPlaylist()
        {
            // Очищаем текущие данные в таблице перед обновлением
            dataGridView1.Rows.Clear();

            // Получаем список всех песен из плейлиста
            song_text = playlist.WriteAllSongs();

            // Для каждой песни извлекаем информацию и добавляем её в таблицу
            foreach (var songs in song_text)
            {
                // Разделяем строку на части: автор, название, имя файла
                string[] parts = songs.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                // Добавляем новую строку в DataGridView с данными о песне
                dataGridView1.Rows.Add(parts[0], parts[1], parts[2]);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Заглушка для обработчика клика по элементам меню strip
        }

        private void Add(object sender, EventArgs e)
        {
            // Получаем данные из текстовых полей
            string author = textBox3.Text.Trim();
            string title = textBox4.Text.Trim();
            string filename = textBox5.Text.Trim();

            // Проверяем, заполнено ли поле с названием файла
            if (string.IsNullOrEmpty(filename))
            {
                MessageBox.Show("Введите название файла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Если указаны автор и название — создаём полноценный объект Song
                if (!string.IsNullOrEmpty(author) && !string.IsNullOrEmpty(title))
                {
                    Song song = new Song
                    {
                        Author = author,
                        Title = title,
                        Filename = filename
                    };

                    playlist.AddSong(song); // Добавляем песню в плейлист
                }
                else
                {
                    // В противном случае добавляем только файл
                    playlist.AddSong(filename);
                }

                // Обновляем отображение таблицы
                CompletionDGVPlaylist();

                // Очищаем поля ввода
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            catch (Exception ex)
            {
                // Ловим возможные ошибки и выводим сообщение
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            // Заглушка для события изменения значения numericUpDown4
        }

        private void Search(object sender, EventArgs e)
        {
            try
            {
                // Сбрасываем выделение цветом всех строк
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.DefaultCellStyle.BackColor = SystemColors.Window;
                }

                // Получаем индекс песни из NumericUpDown
                int index = (int)numericUpDown2.Value;

                // Получаем песню по индексу и обновляем метку
                Song song = playlist.IndexSong(index);
                label7.Text = $"Сейчас играет: {song.Author} - {song.Title} {song.Filename}";

                // Выделяем соответствующую строку в таблице
                if (index >= 0 && index < dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete(object sender, EventArgs e)
        {
            try
            {
                // Получаем текст для удаления
                string del_text = textBox6.Text;

                // Получаем выбранный способ удаления
                int choice = comboBox2.SelectedIndex;

                if (choice >= 0)
                {
                    switch (choice)
                    {
                        case 0:
                            // Удаление по имени файла
                            playlist.DeleteSong(del_text);
                            break;

                        case 1:
                            // Удаление по индексу
                            int index;
                            if (!int.TryParse(del_text, out index) || index <= 0)
                            {
                                MessageBox.Show("Введите корректное число.");
                                return;
                            }
                            playlist.DeleteSong(index);
                            break;

                        case 2:
                            // Удаление по автору, названию и имени файла
                            try
                            {
                                string[] parts = del_text.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                                if (parts.Length != 3)
                                    throw new FormatException("Должно быть три элемента: автор, название, имя файла.");

                                Song song = new Song
                                {
                                    Author = parts[0],
                                    Title = parts[1],
                                    Filename = parts[2]
                                };
                                playlist.DeleteSong(song);
                            }
                            catch
                            {
                                MessageBox.Show("Введите три данных через пробел");
                            }
                            break;
                    }

                    // Обновляем отображение таблицы
                    CompletionDGVPlaylist();
                }
                else
                {
                    MessageBox.Show("Выберите вид удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Next(object sender, EventArgs e)
        {
            try
            {
                // Получаем следующую песню из плейлиста
                Song song = playlist.NextSong();
                label7.Text = $"Сейчас играет: {song.Author} - {song.Title} {song.Filename}";

                // Сбрасываем цвет выделения всех строк
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.DefaultCellStyle.BackColor = SystemColors.Window;
                }

                // Получаем текущий индекс воспроизведения
                int index = playlist.CurrentIndex();

                // Если индекс корректный — выделяем строку
                if (index >= 0 && index < dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
                }

                // Прокручиваем таблицу к текущей строке
                dataGridView1.FirstDisplayedScrollingRowIndex = index;
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Back(object sender, EventArgs e)
        {
            try
            {
                // Получаем предыдущую песню из плейлиста
                Song song = playlist.PreviousSong();
                label7.Text = $"Сейчас играет: {song.Author} - {song.Title} {song.Filename}";

                // Сбрасываем цвет выделения всех строк
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.DefaultCellStyle.BackColor = SystemColors.Window;
                }

                // Получаем текущий индекс воспроизведения
                int index = playlist.CurrentIndex();

                // Если индекс корректный — выделяем строку
                if (index >= 0 && index < dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
                }

                // Прокручиваем таблицу к текущей строке
                dataGridView1.FirstDisplayedScrollingRowIndex = index;
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintSong(object sender, EventArgs e)
        {
            // Обновляем отображение таблицы
            CompletionDGVPlaylist();
        }

        private void Start(object sender, EventArgs e)
        {
            try
            {
                // Сбрасываем цвет выделения всех строк
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.DefaultCellStyle.BackColor = SystemColors.Window;
                }

                // Запускаем проигрывание плейлиста с первой песни
                Song song = playlist.StartPlaylist();
                label7.Text = $"Сейчас играет: {song.Author} - {song.Title} {song.Filename}";

                // Получаем индекс первой песни и выделяем её
                int index = (int)numericUpDown2.Value;
                if (index >= 0 && index < dataGridView1.Rows.Count)
                {
                    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            // Очищаем весь плейлист
            playlist.ClearPlaylist();

            // Обновляем таблицу
            CompletionDGVPlaylist();

            // Очищаем метку с информацией о текущей песне
            label7.Text = "";
        }
    }
}
