using System;
using System.Collections.Generic;
using System.Xml;
using WpfApp1.models;
using Microsoft.Extensions.Logging;


namespace WpfApp1.Share
{
    public class XmlDocumentWorker : IXmlWorker
    {
        private readonly XmlDocument _document;
        private readonly ILogger _logger;
        private string _xmlFilePath;

        public XmlDocumentWorker(ILogger logger)
        {
            _logger = logger;
            _document = new XmlDocument();
        }

        public void Add(Country country)
        {
            var xRoot = _document.DocumentElement;

            XmlElement countryElem = _document.CreateElement("Страна");
            XmlAttribute nameAttribute = _document.CreateAttribute("Название");
            XmlText nameText = _document.CreateTextNode(country.Name);
            nameAttribute.AppendChild(nameText);

            XmlElement areaElem = _document.CreateElement("Площадь");
            XmlText areaInnerText = _document.CreateTextNode(country.Area.ToString());
            areaElem.AppendChild(areaInnerText);

            countryElem.AppendChild(areaElem);

            XmlElement populationElem = _document.CreateElement("Население");
            XmlText populationInnerText = _document.CreateTextNode(country.Population.ToString());
            populationElem.AppendChild(populationInnerText);

            countryElem.AppendChild(populationElem);

            xRoot.AppendChild(countryElem);
            _document.Save(_xmlFilePath);
        }

        public void Delete(string name)
        {
            var xRoot = _document.DocumentElement;
            foreach(XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    var attributeName = xnode.Attributes.GetNamedItem("Название");
                    try
                    {
                        var attributeNameText = attributeName?.InnerText;
                        if (attributeNameText.Equals(name))
                        {
                            xRoot.RemoveChild(xnode);
                        }
                    }
                    catch (Exception ex) when (ex is XmlException || ex is NullReferenceException)
                    {
                        _logger.LogWarning(ex.Message, nameof(attributeName));
                    }
                  
                }
            }
        }

        public Country FindBy(string name)
        {
            Country country = null;
            var xRoot = _document.DocumentElement;
            foreach(XmlNode xmlNode in xRoot)
            {
                country = GetCountry(xmlNode);
                if (country.Name.Equals(name))
                {
                    return country;
                }
            }
            return country;
              
        }

        public List<Country> GetAll()
        {
            List<Country> countries = new List<Country>();
            var xRoot = _document.DocumentElement;
            foreach(XmlNode xnode in xRoot)
            {
                var country = GetCountry(xnode);
                countries.Add(country);
            }
            return countries;

        }
        
        public void Load(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
            _document.Load(xmlFilePath);
        }


        public Country GetCountry(XmlNode node)
        {
            var country = new Country();    
            if(node.Attributes.Count > 0)
            {
                var attributeName = node.Attributes.GetNamedItem("Название");
                country.Name = attributeName?.Value;
            }

            foreach(XmlNode childNode in node.ChildNodes)
            {
                try
                {
                    if (childNode.Name.Equals("Название"))
                    {
                        country.Name = childNode.InnerText;
                    }
                    if (childNode.Name.Equals("Площадь"))
                    {
                        country.Area = double.Parse(childNode.InnerText);
                    }
                    if (childNode.Name.Equals("Население"))
                    {
                        country.Population = double.Parse(childNode.InnerText);
                    }
                }
                catch(Exception ex) when (ex is FormatException || ex is NullReferenceException)
                {
                    _logger.LogError(ex.Message, ex.StackTrace, nameof(childNode.InnerText));
                }
            }
            return country;
        }

    }
}
