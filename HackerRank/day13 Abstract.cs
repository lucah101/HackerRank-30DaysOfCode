using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{

    protected String title;
    protected String author;

    public Book(String t, String a)
    {
        title = t;
        author = a;
    }
    public abstract void display();


}

//Write MyBook class
class MyBook : Book
{
    private int price;

    public MyBook(string title, string author, int price) : base(title, author)
    {
        this.price = price;
    }

    public override void display()
    {
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}

class Solution13
{
    static void Day13(String[] args)
    {
        String title = Console.ReadLine();
        String author = Console.ReadLine();
        int price = Int32.Parse(Console.ReadLine());
        Book new_novel = new MyBook(title, author, price);
        new_novel.display();
    }
}


// The Alchemist
// Paulo Coelho
// 248