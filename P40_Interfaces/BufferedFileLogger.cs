public class BufferedFileLogger
{
    private readonly string _filePath;
    private readonly int _entryLimit;
    private readonly List<string> _buffer;

    public BufferedFileLogger(string filePath, int entryLimit)
    {
        _filePath = filePath;
        _entryLimit = entryLimit;
        _buffer = new List<string>();
    }

    public void Log(string message)
    {
        if (_buffer.Count == _entryLimit)
        {
            _buffer.Add(message);
        }
        if (_buffer.Count > _entryLimit)
        {
            Flush();
            _buffer.Add(message);
        }
        else
        {
            Console.WriteLine("Input failed");
        }
    }

    public void Flush() //isvalo buferi ir iraso i faila
    {
        if (_buffer.Count > 0)
        {
            File.AppendAllLines(_filePath, _buffer);
            _buffer.Clear();
        }
    }
}
