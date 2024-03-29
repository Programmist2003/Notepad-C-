using System;
using System.Collections.Generic;
using System.IO;

List<string> notes = new List<string>();

Console.WriteLine("Приветсвую вас в блокноте!");

bool exit = false;
while (!exit)
{
    Console.WriteLine("\n Выберите команды:");
    Console.WriteLine("1. Посмотреть заметки");
    Console.WriteLine("2. Добавить заметку");
    Console.WriteLine("3. Удалить заметку");
    Console.WriteLine("4. Сохранить заметку");
    Console.WriteLine("5. Выйти из блокнота");

#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
    int choice = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.

    switch (choice)
    {
        case 1:
            ShowNotes();
            break;
        case 2:
            AddNote();
            break;
        case 3:
            DeleteNote(int.Parse(Console.ReadLine()) - 1);
            break;
        case 4:
            SaveNotes();
            break;
        case 5:
            exit = true;
            break;
        default:
            Console.WriteLine("Неверный выбор. Попробуйте снова.");
            break;
    }
}

void SaveNotes()
{
    throw new NotImplementedException();
}

void ShowNotes()
{
    Console.WriteLine("\nВаши заметки:");
    for (int i = 0; i < notes.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {notes[i]}");
    }
}

void AddNote()
{
    Console.Write("\nВведите новую заметку: ");
    string newNote = Console.ReadLine();
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
    notes.Add(newNote);
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
    Console.WriteLine("Заметка успешно добавлена.");
}

void DeleteNote(int index) { Console.Write("\nВведите номер заметки для удаления: ");} // Возможно, аргумент-ссылка, допускающий значение NULL.}