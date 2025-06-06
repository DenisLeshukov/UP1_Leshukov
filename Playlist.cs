using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP1_Leshukov
{
    // Класс Playlist представляет собой модель плейлиста — список песен с возможностью навигации
    class Playlist
    {
        // Список песен в плейлисте
        private List<Song> list;

        // Индекс текущей (воспроизводимой) песни
        private int currentIndex;

        // Конструктор: инициализирует пустой список и устанавливает начальный индекс на 0
        public Playlist()
        {
            list = new List<Song>();
            currentIndex = 0;
        }

        // Возвращает текущую песню из плейлиста
        public Song CurrentSong()
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }

        // Формирует список строк, где каждая строка содержит информацию о песне:
        // "Автор Название ИмяФайла"
        public List<string> WriteAllSongs()
        {
            List<string> songs = new List<string>();

            foreach (var song in list)
            {
                songs.Add($"{song.Author} {song.Title} {song.Filename}");
            }

            return songs;
        }

        // Добавляет новую песню в плейлист, указывая автора, название и имя файла
        public void AddSong(string author, string title, string filename)
        {
            Song song = new Song();
            song.Author = author;
            song.Title = title;
            song.Filename = filename;

            list.Add(song);
        }

        // Добавляет уже созданный объект Song в плейлист
        public void AddSong(Song song)
        {
            list.Add(song);
        }

        // Добавляет песню по имени файла. Автор ставится как "Неизвестный",
        // название берётся из имени файла без расширения
        public void AddSong(string filename)
        {
            int index = filename.IndexOf('.');

            if (index >= 0)
            {
                Song song = new Song();
                song.Author = "Неизвестный";
                song.Title = filename.Remove(index); // Удаляем расширение
                song.Filename = filename;

                list.Add(song);
            }
        }

        // Переход к следующей песне в плейлисте
        public Song NextSong()
        {
            if (list.Count > 0)
            {
                currentIndex++;

                if (currentIndex >= list.Count)
                {
                    throw new IndexOutOfRangeException("Невозможно выйти за пределы плейлиста");
                }
                else
                    return list[currentIndex];
            }
            else
            {
                throw new IndexOutOfRangeException("Список пустой");
            }
        }

        // Переход к предыдущей песне в плейлисте
        public Song PreviousSong()
        {
            if (list.Count > 0)
            {
                currentIndex--;

                if (currentIndex < 0)
                {
                    throw new IndexOutOfRangeException("Невозможно выйти за пределы плейлиста");
                }
                else
                    return list[currentIndex];
            }
            else
            {
                throw new IndexOutOfRangeException("Список пустой");
            }
        }

        // Получает песню по указанному индексу и делает её текущей
        public Song IndexSong(int index)
        {
            if (list.Count > 0)
            {
                if (index < 0)
                {
                    throw new IndexOutOfRangeException("Индекс не может быть отрицательным");
                }
                if (index >= list.Count)
                {
                    throw new IndexOutOfRangeException("Индекс выходит за границы");
                }

                currentIndex = index;
                return list[currentIndex];
            }
            else
            {
                throw new IndexOutOfRangeException("Список пустой");
            }
        }

        // Запускает воспроизведение плейлиста с первой песни
        public Song StartPlaylist()
        {
            if (list.Count > 0)
            {
                currentIndex = 0;
                return list[currentIndex];
            }
            else
            {
                throw new IndexOutOfRangeException("Список пустой");
            }
        }

        // Удаляет все песни с заданным именем файла
        public void DeleteSong(string file)
        {
            // Удаляем все элементы, у которых Filename совпадает с переданным файлом
            list.RemoveAll(song => song.Filename == file);
        }

        // Удаляет песню по указанному индексу
        public void DeleteSong(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Индекс не может быть отрицательным");
            }
            if (index >= list.Count)
            {
                throw new IndexOutOfRangeException("Индекс выходит за границы");
            }

            list.RemoveAt(index);
        }

        // Удаляет конкретную песню (по ссылке на объект Song)
        public void DeleteSong(Song song)
        {
            list.Remove(song);
        }

        // Очищает весь плейлист
        public void ClearPlaylist()
        {
            list.Clear();
        }

        // Возвращает текущий индекс воспроизводимой песни
        public int CurrentIndex()
        {
            return currentIndex;
        }
    }
}
