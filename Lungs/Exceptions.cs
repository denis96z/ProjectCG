using System;

namespace Lungs
{
    abstract class LungsException : Exception
    {
        private string _Text;

        protected LungsException(string text)
        {
            _Text = text;
        }

        public override string ToString()
        {
            return _Text;
        }
    }

    class MemoryAllocationException : LungsException
    {
        public MemoryAllocationException() :
            base("Недостаточно памяти для выполнения операции!") { }
    }

    class IndexOutOfRangeException : LungsException
    {
        public IndexOutOfRangeException() :
            base("Индекс вне границ массива!") { }
    }

    class IllegalModificationException : LungsException
    {
        public IllegalModificationException() :
            base("Попытка проведения недопустимого преобразования!") { }
    }

    class FileStructureException : LungsException
    {
        public FileStructureException() :
            base("Содержимое файла невозможно прочитать!") { }
    }
}