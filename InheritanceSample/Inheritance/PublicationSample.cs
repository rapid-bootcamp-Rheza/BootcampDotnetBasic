using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample.Inheritance
{
    public enum PublicationType { Misc, Book, Magazine, Article };
    public abstract class PublicationSample
    {
        private bool published = false;
        private DateTime _datePublished;
        private int totalPages;

        public PublicationSample(string title, string publisher, PublicationType type)
        {
            if (string.IsNullOrWhiteSpace(publisher))
            {
                throw new ArgumentException("The name of publisher is required.");
            }
            Publisher = publisher;
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("The tittle name is required.");
            }
            Title = title;

            Type = type;
        }

        public string Publisher { get; }
        public string Title { get; }
        public PublicationType Type { get; }
        public string? CopyrightName { get; private set; }

        public int CopyrightDate { get; private set; }

        public int Pages
        {
            get { return totalPages; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "The number of pages cannot null.");
                }
                totalPages = value;
            }
        }
        public string GetPublicationDate()
        {
            if (!published)
            {
                return "NYP";
            }
            else
            {
                return _datePublished.ToString("d");
            }
        }
        public void Publish(DateTime datePublished)
        {
            published = true;
            _datePublished = datePublished;
        }

        public void CopyRight(string copyrightName, int copyrightDate)
        {
            if (string.IsNullOrWhiteSpace(copyrightName))
            {
                throw new ArgumentException("the name of the copyright name holder cannot empty.");
            }
            CopyrightName = copyrightName;
            int Currentyear = DateTime.Now.Year;
            if (copyrightDate < Currentyear - 10 || copyrightDate > Currentyear + 2)
            {
                throw new ArgumentOutOfRangeException($"The Copyright year must be between {Currentyear - 10}and{Currentyear + 1}");

            }
            CopyrightDate = copyrightDate;
        }

        public override string ToString() => Title;

    }
}
