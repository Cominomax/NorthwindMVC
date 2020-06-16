using NorthwindMVC.Website.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindMVC.Website.Models
{
    public class CarouselViewModel
    {
        public CarouselViewModel(string carouselName, IList<ICanShowAsCard> elements, int elementsPerSlide)
        {
            CarouselName = carouselName;
            Elements = elements;
            ElementsPerSlide = elementsPerSlide;
        }

        public string CarouselName { get; set; }
        public bool IsSingleCardPerSlide => ElementsPerSlide == 1;
        public int ElementsPerSlide { get; set; }
        public IList<ICanShowAsCard> Elements { get; set; }
        public int Count => Elements.Count;
        public int NumberOfSlides => (int)Math.Ceiling((decimal)Count / ElementsPerSlide);
        public string ShouldBeActive(int i) => i == 0 ? "active" : "";

        public IList<ICanShowAsCard> GetNextChunkToDisplay(int i)
        {
            return Elements.Skip(i).Take(ElementsPerSlide).ToList();
        }

        public ICanShowAsCard this[int index]   // Indexer declaration  
        {
            get
            {
                return Elements[index];
            }
        }
    }
}
