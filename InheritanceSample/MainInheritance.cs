using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InheritanceSample.Inheritance.SampleInheritance;
using static InheritanceSample.Inheritance.SimpleClass;
using static InheritanceSample.Inheritance.Automobile;
using static InheritanceSample.Inheritance.BookSample;
using static InheritanceSample.Inheritance.PublicationSample;
using InheritanceSample.Inheritance;

namespace InheritanceSample
{
    public class MainInheritance
    {
        public class EmptyClass
        {
            
        }
        public static void Main()
        {
            //Inheritance1();
            //ExampleSimpleClass();
            // EmptyClassExample();
            //SampleAutomobile();

            // BookPublisher();

            SampleShape();
        }

        #region Shape Sample
        public static void SampleShape()
        {
            Shape[] shapes = { new Rectangle(10, 12), new Square(6), new Circle(3) };
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape}: area, {Shape.GetArea(shape)}: "+ $"perimeter, {Shape.GetPerimeter(shape)}");
                if (shape is Rectangle rect)
                {
                    Console.WriteLine($"  Is Square: {rect.IsSquare()}, Diagonal : {rect.Diagonal}");
                    continue;
                }
                if (shape is Square sq)
                {
                    Console.WriteLine($"    Diagonal: {sq.Diagonal}");
                    continue;
                }
            }
        }
        #endregion

        #region MyBook Sample
        public static void BookPublisher()
        {
            var book = new BookSample("The Tempest", "0971655819", "Shakespeare, William",
                            "Public Domain Press");
            ShowPublicationInfo(book);
            book.Publish(new DateTime(2016, 8, 16));
            ShowPublicationInfo(book);

            var book2 = new BookSample("The Tempest", "Classic Works Press", "Shakespeare , William");
            Console.Write($"{book.Title} and {book2.Title} are the same publication: " +
                  $"{((PublicationSample)book).Equals(book2)}");
        }

        public static void ShowPublicationInfo(PublicationSample pub)
        {
            string pubDate = pub.GetPublicationDate();
            Console.WriteLine($"{pub.Title}, " +
                  $"{(pubDate == "NYP" ? "Not Yet Published" : "published on " + pubDate):d} by {pub.Publisher}");
        }
        #endregion

        #region Automobile
        public static void SampleAutomobile()
        {
            var chevy = new Automobile("Chevrolete", "Camaro", 1970);
            Console.WriteLine(chevy);

            var packard = new Automobile("Packard", "Custom Eight", 1948);
            Console.WriteLine(packard);

            
        }
        #endregion
        #region Sample EmptyClass inheritance
        public static void EmptyClassExample()
        {
            EmptyClass sc = new();
            Console.WriteLine(sc.ToString());
        }
        #endregion

        #region Sample Inheritance
        public static void Inheritance1()
        {


        //var b = new A.B();
           // Console.WriteLine(b.GetValue());
        }
        #endregion

        #region With method
        public static void WithMethod1()
        {
            B b = new();
            b.Method1();
        }
        #endregion
    }
}
