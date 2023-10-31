using System;

class Program
{
    static void Main(string[] args)
    {
        Violin violin = new Violin("Violin", "A string instrument with four strings.", "The violin has a long history in classical music.");
        Trombone trombone = new Trombone("Trombone", "A brass instrument with a slide.", "The trombone is often used in brass bands.");
        Ukulele ukulele = new Ukulele("Ukulele", "A small, four-stringed instrument.", "The ukulele is known for its sweet and cheerful tone.");
        Violonchele violonchele = new Violonchele("Violonchele", "A large, deep-toned string instrument.", "The violonchele is a vital part of many orchestras.");

        violin.Show();
        violin.Sound();
        violin.Desc();
        violin.History();

        Console.WriteLine();

        trombone.Show();
        trombone.Sound();
        trombone.Desc();
        trombone.History();

        Console.WriteLine();

        ukulele.Show();
        ukulele.Sound();
        ukulele.Desc();
        ukulele.History();

        Console.WriteLine();

        violonchele.Show();
        violonchele.Sound();
        violonchele.Desc();
        violonchele.History();
    }
}

class MusicInstrument
{
    private string name;
    private string description;
    private string history;

    public MusicInstrument(string name, string description, string history)
    {
        this.name = name;
        this.description = description;
        this.history = history;
    }

    public virtual void Sound()
    {
        System.Console.WriteLine("Instrument makes a sound.");
    }

    public void Show()
    {
        System.Console.WriteLine($"Instrument name: {name}");
    }

    public void Desc()
    {
        System.Console.WriteLine($"Instrument description: {description}");
    }

    public void History()
    {
        System.Console.WriteLine($"Instrument history: {history}");
    }
}

class Violin : MusicInstrument
{
    public Violin(string name, string description, string history) : base(name, description, history) { }

    public override void Sound()
    {
        System.Console.WriteLine("Violin makes a beautiful musical sound.");
    }
}

class Trombone : MusicInstrument
{
    public Trombone(string name, string description, string history) : base(name, description, history) { }

    public override void Sound()
    {
        System.Console.WriteLine("Trombone makes a deep melodic sound.");
    }
}

class Ukulele : MusicInstrument
{
    public Ukulele(string name, string description, string history) : base(name, description, history) { }

    public override void Sound()
    {
        System.Console.WriteLine("Ukulele makes a very positive melody.");
    }
}

class Violonchele : MusicInstrument
{
    public Violonchele(string name, string description, string history) : base(name, description, history) { }

    public override void Sound()
    {
        System.Console.WriteLine("Violonchele makes a beautiful deep musical sound.");
    }
}